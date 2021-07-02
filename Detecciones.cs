using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Horus
{
    public partial class Detecciones : Form
    {
        String ServerAPIURL = "" + Program.Server;
        String GlobalUUID = "";
        String GlobaType = "";
        Panel SubPanel;

        public Detecciones(String UUID = "", String Type = "")
        {
            GlobalUUID = UUID;
            GlobaType = Type;

            InitializeComponent();
        }

        private void LoadDetections()
        {
            this.MainPanel.Visible = false;
            this.WaitAnimation.Visible = true;
            // Application.DoEvents();

            try
            {
                System.Threading.Thread.Sleep(100);


                WebClient webClient = new WebClient();
                webClient.Headers.Add("Authorization", "Bearer " + Program.LogInToken);

                String response = webClient.DownloadString(ServerAPIURL + "/api/v2/admin/accounts/users/profiles=" + GlobalUUID + "/detections");

                String[] RecivedMatrix = response.Split('|');

                ListaDeDetecciones.Rows.Clear();

                if (RecivedMatrix[0] == "200")
                {
                    String[] UserList = response.Split('\n');

                    foreach (String User in UserList)
                    {
                        // Application.DoEvents();
                        if (User != "")
                        {
                            RecivedMatrix = User.Split('|');

                            String code = RecivedMatrix[0];
                            String uuid = RecivedMatrix[1];
                            String name = RecivedMatrix[2];

                            if (code == "200")
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(ListaDeDetecciones);

                                row.Height = 40;

                                row.Cells[0].Value = name;
                                row.Cells[1].Value = uuid;
                                ListaDeDetecciones.Rows.Add(row);
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
            WaitAnimation.Top = (this.Height / 2) - (WaitAnimation.Height / 2);
            WaitAnimation.Left = (this.Width / 2) - (WaitAnimation.Width / 2);

            if (this.Width < 1000)
                this.Route.Visible = false;
            else
                this.Route.Visible = true;
        }

        private void SubPanel_unload(object sender, FormClosedEventArgs e) {
            this.MainPanel.Visible = true;
            SubPanel.Visible = false;
            SubPanel.Dispose();
            SubPanel = null;
            LoadDetections();
        }
        private void ListaDeDetecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String UUID = "";

                if (e.ColumnIndex == 2 && e.RowIndex > -1)
                {
                    try
                    {
                        if (e.RowIndex > -1)
                            UUID = this.ListaDeDetecciones.Rows[e.RowIndex].Cells[1].Value.ToString();

                        SubPanel = new Panel();
                        SubPanel.Dock = DockStyle.Fill;

                        this.Controls.Add(SubPanel);

                        SubPanel.Show();

                        this.MainPanel.Visible = false;

                        ModifyDetection ModifyDetection_Window = new ModifyDetection(UUID, GlobalUUID);
                        ModifyDetection_Window.TopLevel = false;
                        ModifyDetection_Window.Dock = DockStyle.Fill;

                        SubPanel.Controls.Add(ModifyDetection_Window);

                        ModifyDetection_Window.Show();

                        ModifyDetection_Window.FormClosed += new FormClosedEventHandler(SubPanel_unload);
                    }
                    catch { }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void Button8_Click(object sender, EventArgs e) 
        {
            try {
                SubPanel = new Panel();
                SubPanel.Dock = DockStyle.Fill;

                this.Controls.Add(SubPanel);

                SubPanel.Show();

                this.MainPanel.Visible = false;

                Configuracion configuracion_windows = new Configuracion(GlobalUUID);
                configuracion_windows.TopLevel = false;
                configuracion_windows.Dock = DockStyle.Fill;

                SubPanel.Controls.Add(configuracion_windows);

                configuracion_windows.Show();

                configuracion_windows.FormClosed += new FormClosedEventHandler(SubPanel_unload);
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            timer1.Enabled = false;
            LoadDetections();
        }
    }
}
