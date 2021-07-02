using System;
using System.Windows.Forms;
using System.Drawing;

namespace Horus {
    public partial class AreaSelector : Form 
    {
        private const int
        HTLEFT = 10,
        HTRIGHT = 11,
        HTTOP = 12,
        HTTOPLEFT = 13,
        HTTOPRIGHT = 14,
        HTBOTTOM = 15,
        HTBOTTOMLEFT = 16,
        HTBOTTOMRIGHT = 17;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, 3); } }
        Rectangle Left { get { return new Rectangle(0, 0, 3, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - 3, this.ClientSize.Width, 3); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - 3, 0, 3, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, 3, 3); } }

        private void AreaSelector_Load(object sender, EventArgs e) 
        {

        }

        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - 3, 0, 3, 3); } }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (this.AreaSize.SelectedIndex == 0) {
                this.Height = 480;
                this.Width = 640;
            }

            if (this.AreaSize.SelectedIndex == 1) {
                this.Height = 600;
                this.Width = 800;
            }

            if (this.AreaSize.SelectedIndex == 2) {
                this.Height = 720;
                this.Width = 1280;
            }

            if (this.AreaSize.SelectedIndex == 3) {
                this.Height = 1080;
                this.Width = 1920;
            }
        }

        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - 3, 3, 3); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - 3, this.ClientSize.Height - 3, 3, 3); } }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void WndProc(ref Message message) 
         {
            base.WndProc(ref message);

            if (message.Msg == 0x84) {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

        public AreaSelector() 
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void AreaSelector_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left) 
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
