using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Net.Http;
using System.Globalization;
using System.Drawing.Drawing2D;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Horus
{
    public partial class Cuentas : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BitBlt(IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, TernaryRasterOperations dwRop);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public enum TernaryRasterOperations : uint {
            SRCCOPY = 0x00CC0020,
            SRCPAINT = 0x00EE0086,
            SRCAND = 0x008800C6,
            SRCINVERT = 0x00660046,
            SRCERASE = 0x00440328,
            NOTSRCCOPY = 0x00330008,
            NOTSRCERASE = 0x001100A6,
            MERGECOPY = 0x00C000CA,
            MERGEPAINT = 0x00BB0226,
            PATCOPY = 0x00F00021,
            PATPAINT = 0x00FB0A09,
            PATINVERT = 0x005A0049,
            DSTINVERT = 0x00550009,
            BLACKNESS = 0x00000042,
            WHITENESS = 0x00FF0062,
            CAPTUREBLT = 0x40000000
        }

        IntPtr hwnd = IntPtr.Zero;

        String ServerAPIURL = "" + Program.Server;
        Panel SubPanel;
        String uuid;
        String user;

        String EndPoint = "";
        String ServerUser = Program.User;
        String ServerPassword = Program.Password;
        String Profile = "";

        String token = "";
        String Recivedtmp = "";

        Boolean Ready = true;

        Int32 AreaTop = 0;
        Int32 AreaLeft = 0;
        Int32 AreaHeight = 0;
        Int32 AreaWidth = 0;

        Int32 ProgramMode = 0;

        Image Preview;
        Bitmap captureBitmap;

        MiniVisor MiniVisor_Window;

        String MediaFile = "";

        PluginServices PluginsService = new PluginServices();
        AvailablePlugin selectedPlugin = new AvailablePlugin();

        Image<Bgr, Byte> currentFrame;
        Capture grabber;

        Int32 SlotsIndex = 0;

        struct ProfileVars 
        {
            public Int32 Type;
            public String UUDI;
            public String Name; 
        }

        struct EstadisticasVars 
        {
            public String Name;
            public Double Value;
        }

        ProfileVars[] Profiler;
        EstadisticasVars[] Statistics;

        private Int32 GetSlots() {

            Int32 Count = 0;
            foreach (Boolean Slot in Program.Slots) {
                if (Slot == false) 
                    return Count;

                Count++;
            }

            return 0;
        }

        private void LoadProfiles() 
        {
            try {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Authorization", "Bearer " + Program.LogInToken.Trim());

                String response = webClient.DownloadString(ServerAPIURL + "/api/v2/admin/accounts/users=" + uuid + "/profiles");

                String[] RecivedMatrix = response.Split('|');

                if (RecivedMatrix[0] == "200") 
                {
                    String[] ProfilesList = response.Split('\n');

                    Profiler = new ProfileVars[ProfilesList.Length];
                    this.Perfiles.Items.Clear();

                    Int32 Counter = 0;

                    foreach (String Profile in ProfilesList) 
                    {
                        if (Profile != "") 
                        {
                            RecivedMatrix = Profile.Split('|');

                            String code = RecivedMatrix[0];

                            if (code == "200") 
                            {
                                Profiler[Counter].Type = System.Convert.ToInt32(RecivedMatrix[4]);
                                Profiler[Counter].UUDI = RecivedMatrix[1];
                                Profiler[Counter].Name = RecivedMatrix[2];

                                this.Perfiles.Items.Add(Profiler[Counter].Name);

                                Counter++;
                            }
                        }
                    }
                }
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height) {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format) {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs) {
                if (codec.FormatID == format.Guid) {
                    return codec;
                }
            }
            return null;
        }

        public MemoryStream ImageToStream(Image imageIn) {
            MemoryStream ms = new MemoryStream();
            ImageCodecInfo myImageCodecInfo;
            Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;

            myImageCodecInfo = GetEncoder(ImageFormat.Jpeg);
            myEncoder = Encoder.Quality;
            myEncoderParameters = new EncoderParameters(1);

            myEncoderParameter = new EncoderParameter(myEncoder, 80L);
            myEncoderParameters.Param[0] = myEncoderParameter;

            imageIn.Save(ms, myImageCodecInfo, myEncoderParameters);

            return ms;

        }

        public byte[] ImageToByteArray(Image imageIn) {
            return ImageToStream(imageIn).ToArray();
        }

        public async void GetToken() {
            if (token == "") {
                Ready = false;

                HttpClient httpClient = new HttpClient();
                MultipartFormDataContent form = new MultipartFormDataContent();
                HttpResponseMessage response;

                form.Add(new StringContent(ServerUser), "user");
                form.Add(new StringContent(ServerPassword), "password");
                form.Add(new StringContent(Profile), "profileuuid");

                response = await httpClient.PostAsync(ServerAPIURL + "/api/v2/functions/login", form);

                response.EnsureSuccessStatusCode();
                httpClient.Dispose();

                String[] RecivedMatrix = response.Content.ReadAsStringAsync().Result.Split('|');

                if (RecivedMatrix[0] == "200") {
                    token = RecivedMatrix[1];
                }
                else {
                    token = "";
                }

                Ready = true;
            }
        }

        public Double UnixTimeNow() {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (Double)timeSpan.TotalSeconds;
        }

        public Cuentas()
        {
            InitializeComponent();
        }

        private void LoadUsers()
        {
            this.MainPanel.Visible = false;
            this.WaitAnimation.Visible = true;

            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Authorization", "Bearer " + Program.LogInToken);

                String response = webClient.DownloadString(ServerAPIURL + "/api/v2/admin/accounts/users");

                String[] RecivedMatrix = response.Split('|');

                if (RecivedMatrix[0] == "200")
                {
                    String[] UserList = response.Split('\n');

                    foreach (String User in UserList)
                    {
                        if (User != "")
                        {
                            RecivedMatrix = User.Split('|');

                            String code = RecivedMatrix[0];
                            String principal = RecivedMatrix[4];

                            if (code == "200")
                            {
                                if (principal == "True")
                                {
                                    
                                    uuid = RecivedMatrix[1];
                                    user = RecivedMatrix[2];

                                    this.WaitAnimation.Visible = false;
                                    this.MainPanel.Visible = true;

                                    return;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }

            this.WaitAnimation.Visible = false;
            this.MainPanel.Visible = true;
        }

        private void Administrator_Resize(object sender, EventArgs e) {
            try {
                WaitAnimation.Top = (this.Height / 2) - (WaitAnimation.Height / 2);
                WaitAnimation.Left = (this.Width / 2) - (WaitAnimation.Width / 2);

                this.splitContainer3.Panel1Collapsed = false;
                this.splitContainer3.Panel2Collapsed = false;
                this.splitContainer3.SplitterDistance = (int)(this.splitContainer3.ClientSize.Width - 400);
            }
            catch { }
        }

        private void SubPanel_unload(object sender, FormClosedEventArgs e) {
            try {
                this.MainPanel.Visible = true;
                SubPanel.Visible = false;
                SubPanel.Dispose();
                SubPanel = null;

                LoadUsers();
            }
            catch { }
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            try {
                timer1.Enabled = false;

                LoadUsers();
                LoadProfiles();
                LoadWindows();

                Administrator_Resize(sender, e);
            }
            catch { }
        }

        private void LoadWindows() { 
            try 
            {
                this.VentanasAbiertas.Items.Clear();

                IntPtr hWnd = IntPtr.Zero;
                foreach (Process pList in Process.GetProcesses()) {
                    String Nombre = pList.MainWindowTitle.Trim();

                    if (Nombre != "")
                        this.VentanasAbiertas.Items.Add(Nombre);
                }
            }
            catch { }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show(this, "¿Quiere cerrar el actual stream?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void AdministrarPerfilesToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            try 
            {
                SubPanel = new Panel();
                SubPanel.Dock = DockStyle.Fill;

                this.Controls.Add(SubPanel);

                SubPanel.Show();

                this.MainPanel.Visible = false;

                Perfiles AdminitradorWindow = new Perfiles(uuid, user);
                AdminitradorWindow.TopLevel = false;
                AdminitradorWindow.Dock = DockStyle.Fill;

                SubPanel.Controls.Add(AdminitradorWindow);

                AdminitradorWindow.Show();

                AdminitradorWindow.FormClosed += new FormClosedEventHandler(SubPanel_unload);

            }
            catch { }
        }

        private void AdministrarCuentaToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            try {
                SubPanel = new Panel();
                SubPanel.Dock = DockStyle.Fill;

                this.Controls.Add(SubPanel);

                SubPanel.Show();

                this.MainPanel.Visible = false;

                ModifyAccount ModifyAccount_window = new ModifyAccount();
                ModifyAccount_window.TopLevel = false;
                ModifyAccount_window.Dock = DockStyle.Fill;

                SubPanel.Controls.Add(ModifyAccount_window);

                ModifyAccount_window.Show();

                ModifyAccount_window.FormClosed += new FormClosedEventHandler(SubPanel_unload);
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void Stop() {
            hwnd = IntPtr.Zero;

            if (grabber != null) {
                grabber.Dispose();
                grabber = null;
            }

            this.timer2.Enabled = false;

            Program.Slots[SlotsIndex] = false;
            Program.PreviewMatrix[SlotsIndex] = null;

            BotonDeCobtrol.Text = "Iniciar";

            this.DefineArea.Enabled = true;
            this.Button1.Enabled = true;
            this.Button2.Enabled = true;
            this.Button3.Enabled = true;
            this.Perfiles.Enabled = true;
            this.administrarPerfilesToolStripMenuItem.Enabled = true;
            this.administrarCuentaToolStripMenuItem.Enabled = true;
            this.PanelDeEntradas.Enabled = true;
            this.CerrarToolStripMenuItem.Enabled = true;

            this.PreviewWindow.Image = null;
            this.PreviewWindow.BackColor = Color.Black;

            MediaFile = "";
        }

        private void Start() {
            hwnd = IntPtr.Zero;
            grabber = null;
            this.Log.Rows.Clear();

            if (this.Perfiles.Items.Count > 0) {
                if (EndPoint.Trim() != "" && Profile.Trim() != "") {

                    if (ProgramMode == 0) {
                        if (AreaWidth == 0 && AreaHeight == 0 && AreaTop == 0 && AreaLeft == 0) {
                            DefineArea_Click(null, null);
                        }
                    }

                    if (ProgramMode == 1) {
                        if (this.VentanasAbiertas.Text.Trim() == "") {
                            MessageBox.Show(this, "Debe seleccionar una ventana a capturar antes de proseguir", "Atención", MessageBoxButtons.OK);

                            return;
                        }
                    }

                    SlotsIndex = GetSlots();
                    Program.Slots[SlotsIndex] = true;


                    Statistics = new EstadisticasVars[10000];

                    this.DefineArea.Enabled = false;
                    this.Button1.Enabled = false;
                    this.Button2.Enabled = false;
                    this.Button3.Enabled = false;
                    this.Perfiles.Enabled = false;
                    this.administrarPerfilesToolStripMenuItem.Enabled = false;
                    this.administrarCuentaToolStripMenuItem.Enabled = false;
                    this.PanelDeEntradas.Enabled = false;
                    this.CerrarToolStripMenuItem.Enabled = false;

                    Ready = true;
                    token = "";
                    Recivedtmp = "";

                    if (ProgramMode == 2)
                        MediaFile = this.URLVideo.Text.Trim();

                    if (ProgramMode == 3)
                        MediaFile = this.MediaText.Text.Trim();

                    if (ProgramMode == 4)
                        MediaFile = this.Devices.SelectedIndex.ToString();

                    BotonDeCobtrol.Text = "Detener";

                    this.timer2.Enabled = true;


                }
                else {
                    MessageBox.Show(this, "Debe seleccionar un perfil de detección", "Atención", MessageBoxButtons.OK);
                }
            }
            else {
                MessageBox.Show(this, "No tiene perfiles de deteccion creados. Cree un perfil en base a un modelo de detección antes de continuar.", "Atención", MessageBoxButtons.OK);
            }
        }

        private void BotonDeCobtrol_Click(object sender, EventArgs e) {
            if (this.timer2.Enabled == false) {
                Start();
            }
            else 
            {
                Stop();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e) 
        {
            try {
                if (grabber != null) {
                    if (grabber.QueryFrame() != null) {
                        currentFrame = grabber.QueryFrame().ToImage<Bgr, Byte>();
                    }
                    else {
                        Stop();

                        MessageBox.Show(this, "Error al conectar con la fuente de video", "Atención", MessageBoxButtons.OK);

                        return;
                    }
                }
            }
            catch 
            {
                Stop();

                MessageBox.Show(this, "Error al conectar con la fuente de video", "Atención", MessageBoxButtons.OK);

                return;
            }

            if (Ready)
                CaptureMyScreen();
        }

        private async void Upload() {
            Bitmap FrameToPlugin = null;
            String ToJson = "{\"Data\":[";

            try {
                if (Preview != null) {
                    if (Preview.Width > 1919 || Preview.Height > 1079) {
                        Preview = ResizeImage(Preview, 1919, 1079);
                    }

                    if (ProgramMode == 1) {
                        AreaWidth = Preview.Width;
                        AreaHeight = Preview.Height;
                    }

                    if (ProgramMode == 2 || ProgramMode == 3 || ProgramMode == 4) {
                        AreaWidth = Preview.Width;
                        AreaHeight = Preview.Height;
                    }

                    FrameToPlugin = new Bitmap(Preview);
                }

                using (Graphics g = Graphics.FromImage(Preview)) {
                    Ready = false;

                    Recivedtmp = "";

                    GetToken();

                    HttpClient httpClient = new HttpClient();
                    MultipartFormDataContent form = new MultipartFormDataContent();
                    HttpResponseMessage response;


                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                    form.Add(new ByteArrayContent(ImageToByteArray(Preview), 0, ImageToByteArray(Preview).Length), "photo", "image");

                    response = await httpClient.PostAsync(ServerAPIURL + EndPoint, form);

                    response.EnsureSuccessStatusCode();
                    httpClient.Dispose();

                    Recivedtmp = response.Content.ReadAsStringAsync().Result;


                    if (Recivedtmp.Trim() != "") {
                        String[] Metadata = Recivedtmp.Split('\n');
                        String[] ReceiveOnMatrix;

                        this.Log.Rows.Clear();

                        foreach (String Metaline in Metadata) {
                            if (Metaline.Trim() != "") {
                                if (Profiler[this.Perfiles.SelectedIndex].Type == 0 || Profiler[this.Perfiles.SelectedIndex].Type == 1 || Profiler[this.Perfiles.SelectedIndex].Type == 4 || Profiler[this.Perfiles.SelectedIndex].Type == 5) {

                                    String[] Values = Metaline.Split('|');


                                    WebClient webClient = new WebClient();
                                    webClient.Headers.Add("Authorization", "Bearer " + token);

                                    String response1 = webClient.DownloadString(ServerAPIURL + "/api/v2/admin/accounts/users/profiles/detections=" + Values[6] + "/name");

                                    String[] RecivedMatrix1 = response1.Split('|');

                                    if (RecivedMatrix1[0] == "200")
                                        Recivedtmp = Metaline.Replace(Values[6], RecivedMatrix1[1]);

                                    ReceiveOnMatrix = Recivedtmp.Split('|');
                                }
                                else {
                                    ReceiveOnMatrix = Metaline.Split('|');
                                }

                                Int32 left = 0;
                                Int32 right = 0;
                                Int32 top = 0;
                                Int32 bottom = 0;
                                String Name = "";
                                Double Confidence = 0;

                                Double ymin = 0;
                                Double xmin = 0;
                                Double ymax = 0;
                                Double xmax = 0;

                                if (ReceiveOnMatrix[0] == "200") {
                                    String DecimalSimbol = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;

                                    if (DecimalSimbol == ",") {
                                        ymin = Convert.ToDouble(ReceiveOnMatrix[2].Replace(".", ","));
                                        xmin = Convert.ToDouble(ReceiveOnMatrix[3].Replace(".", ","));
                                        ymax = Convert.ToDouble(ReceiveOnMatrix[4].Replace(".", ","));
                                        xmax = Convert.ToDouble(ReceiveOnMatrix[5].Replace(".", ","));
                                        Confidence = Convert.ToDouble(ReceiveOnMatrix[8].Replace(".", ","));
                                    }
                                    else {
                                        ymin = Convert.ToDouble(ReceiveOnMatrix[2]);
                                        xmin = Convert.ToDouble(ReceiveOnMatrix[3]);
                                        ymax = Convert.ToDouble(ReceiveOnMatrix[4]);
                                        xmax = Convert.ToDouble(ReceiveOnMatrix[5]);
                                        Confidence = Convert.ToDouble(ReceiveOnMatrix[8]);
                                    }

                                    left = Convert.ToInt32(xmin * AreaWidth);
                                    right = Convert.ToInt32(xmax * AreaWidth);
                                    top = Convert.ToInt32(ymin * AreaHeight);
                                    bottom = Convert.ToInt32(ymax * AreaHeight);

                                    Name = ReceiveOnMatrix[6];

                                    if (selectedPlugin != null) {
                                        Int32 Count = 0;

                                        foreach (String Value in ReceiveOnMatrix) {
                                            if (Count == 0)
                                                ToJson = ToJson + "{\"code\":" + Value + ",";
                                            if (Count == 1)
                                                ToJson = ToJson + "\"value\":\"" + Value + "\",";
                                            if (Count == 2)
                                                ToJson = ToJson + "\"y1\":" + Value + ",";
                                            if (Count == 3)
                                                ToJson = ToJson + "\"x1\":" + Value + ",";
                                            if (Count == 4)
                                                ToJson = ToJson + "\"y2\":" + Value + ",";
                                            if (Count == 5)
                                                ToJson = ToJson + "\"x2\":" + Value + ",";
                                            if (Count == 6)
                                                ToJson = ToJson + "\"detected_id\":\"" + Value + "\",";
                                            if (Count == 7)
                                                ToJson = ToJson + "\"vector_id\":\"" + Value + "\",";
                                            if (Count == 8)
                                                ToJson = ToJson + "\"confidence\":" + Value + "},";

                                            Count++;
                                        }
                                    }
                                }

                                if (Name != "-1" && Name != "FAIL")
                                {
                                    AddToGraph(Name, 1);

                                    g.FillRectangle(new System.Drawing.SolidBrush(Color.FromArgb(200, 255, 0, 0)), left - 2, top - 20, (new Font("Tahoma", 10).SizeInPoints * Name.Length), new Font("Tahoma", 10).Height);
                                    g.DrawString(Name, new Font("Tahoma", 10), new System.Drawing.SolidBrush(Color.FromArgb(255, 255, 255, 255)), new PointF(left, top - 20));

                                    Pen greenPen = new Pen(Color.FromArgb(200, 255, 0, 0), 2);
                                    greenPen.Alignment = PenAlignment.Center;


                                    Rectangle rect = new Rectangle(left, top, right - left, bottom - top);
                                    g.DrawRectangle(greenPen, rect);

                                    String X = System.Convert.ToString(System.Convert.ToInt32((xmin + ((xmax - xmin) / 2)) * 640));
                                    String Y = System.Convert.ToString(System.Convert.ToInt32((ymin + ((ymax - ymin) / 2)) * 480));

                                    DataGridViewRow row = new DataGridViewRow();
                                    row.CreateCells(this.Log);

                                    row.Cells[0].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
                                    row.Cells[1].Value = Name;
                                    row.Cells[2].Value = X;
                                    row.Cells[3].Value = Y;
                                    row.Cells[4].Value = Math.Round(Confidence * 100, 1).ToString() + "%";
                                    this.Log.Rows.Add(row);

                                    this.Log.FirstDisplayedScrollingRowIndex = this.Log.RowCount - 1;
                                }
                            }
                        }
                    }
                }

                try {
                    if (selectedPlugin.Instance != null) {
                        selectedPlugin.Instance.Input = ToJson + "{\"code\":-1}]}";

                        if (FrameToPlugin != null)
                            selectedPlugin.Instance.Frame = ImageToStream(FrameToPlugin);
                    }
                }
                catch { }

                Ready = true;

            }
            catch {
                Ready = true;
            }

            Graficar();

            this.PreviewWindow.Image = Preview;
            this.PreviewWindow.Invalidate();

            try {
                if (Program.MiniVisor_visible == true) {
                    Program.PreviewMatrix[SlotsIndex] = this.PreviewWindow.Image;
                }
                else {
                    if (Program.IsHide == true) {
                        Program.IsHide = false;
                        this.miniVisorToolStripMenuItem.Checked = false;
                    }
                }
            }
            catch { }
        }

        private void CaptureMyScreen() 
        {
            try {
                captureBitmap = null;
            
                if (ProgramMode == 0) {
                    Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

                    captureBitmap = new Bitmap(AreaWidth, AreaHeight, PixelFormat.Format32bppArgb);

                    Graphics captureGraphics = Graphics.FromImage(captureBitmap);

                    captureGraphics.CopyFromScreen(AreaLeft, AreaTop, captureRectangle.Left, captureRectangle.Top, captureRectangle.Size);
                }

                if (ProgramMode == 1) {
                    if (hwnd == IntPtr.Zero) {
                        foreach (Process pList in Process.GetProcesses()) {
                            if (pList.MainWindowTitle.Contains(this.VentanasAbiertas.Text.Trim())) {
                                hwnd = pList.MainWindowHandle;

                                break;
                            }
                        }
                    }

                    int width = 0, height = 0;
                    IntPtr dc = IntPtr.Zero;

                    dc = GetDC(hwnd);

                    RECT rect;

                    if (GetWindowRect(hwnd, out rect)) {
                        width = rect.Right - rect.Left;
                        height = rect.Bottom - rect.Top;
                    }

                    captureBitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);

                    AreaWidth = width;
                    AreaHeight = height;

                    if (dc != IntPtr.Zero) {
                        try {
                            using (Graphics g = Graphics.FromImage(captureBitmap)) {
                                IntPtr bdc = g.GetHdc();
                                try {
                                    BitBlt(bdc, 0, 0, width, height, dc, 0, 0, TernaryRasterOperations.SRCCOPY);
                                }
                                catch {
                                    Stop();
                                }
                                finally {
                                    g.ReleaseHdc(bdc);
                                }
                            }
                        }
                        catch {
                            Stop();
                        }
                        finally {
                            ReleaseDC(hwnd, dc);
                        }
                    }
                    else 
                    {
                        Stop();
                    }
                }

                if (ProgramMode == 2 || ProgramMode == 3 || ProgramMode == 4) {
                    try {
                        if (MediaFile != "" && MediaFile != "-1") {
                            if (grabber == null)
                                if (ProgramMode == 4)
                                    grabber = new Capture(System.Convert.ToInt32(MediaFile));
                                else
                                    grabber = new Capture(MediaFile);

                            if (currentFrame != null) {
                                captureBitmap = currentFrame.ToBitmap();
                            }
                        }
                        else {
                            Stop();

                            if (ProgramMode == 2)
                                MessageBox.Show(this, "Debe escribir la URL de donde obtener el stream de video para continuar.", "Atención", MessageBoxButtons.OK);

                            if (ProgramMode == 3)
                                MessageBox.Show(this, "Debe seleccionar un archivo de video para continuar.", "Atención", MessageBoxButtons.OK);

                            if (ProgramMode == 4)
                                MessageBox.Show(this, "Debe seleccionar un dispositivo de entrada de video para continuar.", "Atención", MessageBoxButtons.OK);
                        }


                        
                    }
                    catch (Exception ex) {
                        Stop();

                        MessageBox.Show(ex.Message);
                    }
                }

                if (captureBitmap != null)
                    Preview = captureBitmap;

                Upload();

            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void DefineArea_Click(object sender, EventArgs e) 
        {
            Program.IsHide = true;


            AreaSelector areaSelector_Window = new AreaSelector();

            if (AreaTop > 0 || AreaLeft > 0 || AreaHeight > 0 || AreaWidth > 0) 
            {
                areaSelector_Window.Top = AreaTop;
                areaSelector_Window.Left = AreaLeft;
                areaSelector_Window.Width = AreaWidth;
                areaSelector_Window.Height = AreaHeight;
            }

            areaSelector_Window.ShowDialog();

            AreaTop = areaSelector_Window.Top;
            AreaLeft = areaSelector_Window.Left;
            AreaHeight = areaSelector_Window.Height;
            AreaWidth = areaSelector_Window.Width;

            Program.IsHide = false;

            areaSelector_Window.Close();

        }

        private void Perfiles_SelectedIndexChanged(object sender, EventArgs e) 
        {
            Profile = Profiler[this.Perfiles.SelectedIndex].UUDI;

            if (Profiler[this.Perfiles.SelectedIndex].Type == 0) // FACEID
                EndPoint = "/api/v2/functions/face/id";
            if (Profiler[this.Perfiles.SelectedIndex].Type == 1) // OBJECT
                EndPoint = "/api/v2/functions/object/detection";
            if (Profiler[this.Perfiles.SelectedIndex].Type == 2) // QR
                EndPoint = "/api/v2/functions/codebar/decoder";
            if (Profiler[this.Perfiles.SelectedIndex].Type == 3) // APLR
                EndPoint = "//api/v2/functions/lpr/id";
            if (Profiler[this.Perfiles.SelectedIndex].Type == 4) // IMAGE ID
                EndPoint = "/api/v2/functions/image/id";
            if (Profiler[this.Perfiles.SelectedIndex].Type == 5) // NUDE
                EndPoint = "/api/v2/functions/classification/nude";
            if (Profiler[this.Perfiles.SelectedIndex].Type == 6) // OCR 
                EndPoint = "/api/v2/functions/ocr/decoder";

        }

        private void Timer3_Tick(object sender, EventArgs e) {
            if (Program.NeedChange == true) 
             {
                Program.NeedChange = false;
                LoadProfiles();
                Profile = "";
                this.Perfiles.Text = "";
            }
        }

        private void MiniVisorToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (this.timer2.Enabled && Program.MiniVisor_visible == false) {
                MiniVisor_Window = new MiniVisor();
                MiniVisor_Window.Show();

                Program.MiniVisor_visible = true;
            }
        }

        private void AddToGraph(String Name, Double Value) 
        {
            if (Name != "-1" && Name != "" && Name != "NOT FOUND" || Name != "FAIL") {
                Int32 Conut = 0;

                foreach (EstadisticasVars Stat in Statistics) {
                    if (Stat.Name == "" || Stat.Name == null) {
                        Statistics[Conut].Name = Name;
                        Statistics[Conut].Value = Value;

                        break;
                    }

                    if (Stat.Name.Trim() == Name) {
                        Statistics[Conut].Value = Statistics[Conut].Value + Value;

                        break;
                    }

                    Conut++;
                }
            }
        }

        private void Graficar() {

            try {
                if (this.Estadisticas != null) {
                    this.Estadisticas.Series["Series1"].Points.Clear();

                    foreach (EstadisticasVars Stat in Statistics) {

                        if (Stat.Name == "" || Stat.Name == null)
                            break;

                        this.Estadisticas.Series["Series1"].Points.AddXY(Stat.Name, Stat.Value);
                    }
                }
            }
            catch { }
        }

        private void SalirToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (MessageBox.Show(this, "¿Quiere cerrar el programa completo con todos los streams abiertos?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void Cuentas_Load(object sender, EventArgs e) 
        {
            if (!Directory.Exists(@"c:\ScreenAI\Plugins")) 
            {
                Directory.CreateDirectory(@"c:\ScreenAI\Plugins");
            }

            PluginsService.FindPlugins(@"c:\ScreenAI\Plugins");

            foreach (AvailablePlugin pluginOn in PluginsService.AvailablePlugins) {
                TreeNode newNode = new TreeNode(pluginOn.Instance.Name);
                this.Plugins.Nodes.Add(newNode);
                newNode = null;
            }
        }

        private void Plugins_AfterSelect(object sender, TreeViewEventArgs e) 
        {
            if (this.Plugins.SelectedNode != null) {
                selectedPlugin = PluginsService.AvailablePlugins.Find(this.Plugins.SelectedNode.Text.ToString());

                if (selectedPlugin != null) {

                    this.pnlPlugin.Controls.Clear();

                    selectedPlugin.Instance.MainInterface.Dock = DockStyle.Fill;

                    this.pnlPlugin.Controls.Add(selectedPlugin.Instance.MainInterface);

                }
            }
        }

        private void CarpetaDePluginsToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (!Directory.Exists(@"c:\ScreenAI\Plugins")) {
                Directory.CreateDirectory(@"c:\ScreenAI\Plugins");
            }

            Process.Start(@"c:\ScreenAI\Plugins");
        }

        private void SelectCapMode_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.SelectCapMode.SelectedIndex == 0) {
                this.DefineArea.Visible = true;
                this.AreaPanel.Visible = false;
                this.URLPanel.Visible = false;
                this.MediaPanel.Visible = false;
                this.DevicesPanel.Visible = false;
                ProgramMode = 0;
            }

            if (this.SelectCapMode.SelectedIndex == 1) {
                LoadWindows();
                this.DefineArea.Visible = false;
                this.AreaPanel.Visible = true;
                this.URLPanel.Visible = false;
                this.MediaPanel.Visible = false;
                this.DevicesPanel.Visible = false;
                ProgramMode = 1;
            }

            if (this.SelectCapMode.SelectedIndex == 2) {
                this.DefineArea.Visible = false;
                this.AreaPanel.Visible = false;
                this.URLPanel.Visible = true;
                this.MediaPanel.Visible = false;
                this.DevicesPanel.Visible = false;
                ProgramMode = 2;
            }

            if (this.SelectCapMode.SelectedIndex == 3) {
                this.DefineArea.Visible = false;
                this.AreaPanel.Visible = false;
                this.URLPanel.Visible = false;
                this.MediaPanel.Visible = true;
                this.DevicesPanel.Visible = false;
                ProgramMode = 3;
            }

            if (this.SelectCapMode.SelectedIndex == 4) {
                this.Devices.Text = "";
                this.Devices.Items.Clear();
                listlocalwebcam.load(this.Devices);
                this.DefineArea.Visible = false;
                this.AreaPanel.Visible = false;
                this.URLPanel.Visible = false;
                this.MediaPanel.Visible = false;
                this.DevicesPanel.Visible = true;
                ProgramMode = 4;
            }
        }

        private void AbrirMedia_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "MP4 files (*.mp4)|*.mp4|MOV files(*.mov)|*.mov|AVI files(*.avi)|*.avi|M4V files(*.m4v)|*.m4v|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName.Trim() != "") {
                this.MediaText.Text = openFileDialog1.FileName.Trim();
            }
        }

        private void ScreenAIWebToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("http://www.proyectohorus.com.ar/ScreenAI");
        }

        private void GitHubToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/seamansrl/Plugin_4_ScreenAI");
        }

        private void ContenidoExclusivoToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("https://www.patreon.com/FernandoManiglia");
        }

        private void label15_Click(object sender, EventArgs e) {
            if (this.panel1.Width == 93) {
                this.panel1.Width = 250;
                this.label15.Text = "<< Screen AI";
                Administrator_Resize(sender, e);
                this.Button1.Visible = true;
                this.Button2.Visible = true;
                this.Button3.Visible = true;
            }

            else {
                this.panel1.Width = 93;
                this.label15.Text = "Menu >>";
                Administrator_Resize(sender, e);
                this.Button1.Visible = false;
                this.Button2.Visible = false;
                this.Button3.Visible = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            AdministrarPerfilesToolStripMenuItem_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e) {
            AdministrarCuentaToolStripMenuItem_Click(sender, e);
        }

        private void Button3_Click(object sender, EventArgs e) {
            SalirToolStripMenuItem1_Click(sender, e);
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show(this, "¿Quiere cerrar el actual stream?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
