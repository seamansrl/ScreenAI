using System;
using System.Diagnostics;
using System.Net.Http;
using System.Windows.Forms;
using ZedGraph;

namespace Horus
{
    public partial class Landing : Form {
        String ServerAPIURL = "" + Program.Server;
        Panel SubPanel;
        Int32 TabInstances = 0;

        public Landing() {
            InitializeComponent();
        }

        private async void Access() {

            this.MainPanel.Visible = false;
            this.WaitAnimation.Visible = true;

            try {
                if (this.Clave.Text.Trim() != "" && this.Usuario.Text.Trim() != "") {
                    HttpClient httpClient = new HttpClient();
                    MultipartFormDataContent form = new MultipartFormDataContent();
                    HttpResponseMessage response;

                    form.Add(new StringContent(this.Usuario.Text.Trim()), "user");
                    form.Add(new StringContent(this.Clave.Text.Trim()), "password");

                    response = await httpClient.PostAsync(ServerAPIURL + "/api/v2/admin/login", form);

                    response.EnsureSuccessStatusCode();
                    httpClient.Dispose();
                    String[] RecivedMatrix = response.Content.ReadAsStringAsync().Result.Split('|');

                    if (RecivedMatrix[0] == "200") 
                    {
                        Program.User = this.Usuario.Text.Trim();
                        Program.Password = this.Clave.Text.Trim();
                        Program.LogInToken = RecivedMatrix[1];

                        TabInstances = 0;

                        NewStream_Click(null, null);

                        this.Usuario.Text = "";
                        this.Clave.Text = "";
                    }
                    else {
                        this.MainPanel.Visible = true;
                        this.WaitAnimation.Visible = false;
                        // Application.DoEvents();
                        MessageBox.Show(RecivedMatrix[1], "Atención", MessageBoxButtons.OK);
                    }
                }
                else {
                    this.MainPanel.Visible = true;
                    this.WaitAnimation.Visible = false;
                    // Application.DoEvents();
                    MessageBox.Show("Faltan datos", "Atención", MessageBoxButtons.OK);
                }
            }
            catch (Exception Ex) {
                this.MainPanel.Visible = true;
                this.WaitAnimation.Visible = false;
                // Application.DoEvents();
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }

            this.WaitAnimation.Visible = false;
        }


        private void Alta_Click(object sender, EventArgs e) {
            try {
                Process.Start("https://www.proyectohorus.com.ar/Administrador/AddAccount");
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void SubPanel_unload(object sender, FormClosedEventArgs e) {
            this.Streams.TabPages.Remove(this.Streams.SelectedTab);

            if (this.Streams.TabCount == 0) {
                this.MainPanel.Visible = true;
                TabInstances = 0;
            }
        }

        private void Aceptar_Click(object sender, EventArgs e) {
            Access();
        }

        private void Landing_Resize(object sender, EventArgs e) {
            LoginPanel.Top = (this.Height / 2) - (LoginPanel.Height / 2);
            //LoginPanel.Left = (this.Width / 2) - (LoginPanel.Width / 2);

            WaitAnimation.Top = (this.Height / 2) - (WaitAnimation.Height / 2);
            WaitAnimation.Left = (this.Width / 2) - (WaitAnimation.Width / 2);

            // Application.DoEvents();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://www.proyectohorus.com.ar");
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            if (Program.IsHide == true && this.Visible == true)
                this.Visible = false;

            if (Program.IsHide == false && this.Visible == false)
                this.Visible = true;
        }

        private void NewStream_Click(object sender, EventArgs e) {
            try {
                if (this.Streams.TabCount >= Program.MaxStreams) {
                    MessageBox.Show(this, "Maxima cantidad de streams alcanzada. Adquiera una version full para conseguir más funciones.", "Atencion", MessageBoxButtons.OK);
                    return;
                }

                TabInstances++;

                String title = "Stream " + TabInstances.ToString();

                TabPage myTabPage = new TabPage(title);
                this.Streams.TabPages.Add(myTabPage);

                Cuentas CuentasWindow = new Cuentas();
                CuentasWindow.TopLevel = false;
                CuentasWindow.Dock = DockStyle.Fill;

                myTabPage.Controls.Add(CuentasWindow);

                CuentasWindow.Show();

                this.MainPanel.Visible = false;

                CuentasWindow.FormClosed += new FormClosedEventHandler(SubPanel_unload);

                this.Streams.SelectedIndex = this.Streams.TabCount - 1;
            }
            catch { }
        }

        private void Landing_Load(object sender, EventArgs e) {
            this.LoginPanel.Left = 0;
            this.LoginPanel.Visible = true;
        
            for (Int32 LeftMove = (this.LoginPanel.Width * -1); LeftMove < -9; LeftMove = LeftMove + 30) {
                this.LoginPanel.Left = LeftMove;
                Landing_Resize(sender, e);
            }

            this.Usuario.Focus();
        }
    }
}
