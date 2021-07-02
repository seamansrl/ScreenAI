using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Horus
{
    public partial class Configuracion : Form
    {
        String ServerAPIURL = "" + Program.Server;
        String GlobalUUID = "";
        Panel SubPanel;
        public Configuracion(String UUID = "")
        {
            InitializeComponent();

            GlobalUUID = UUID;
        }

        private void LoadConfigs()
        {
            this.MainPanel.Visible = false;
            this.WaitAnimation.Visible = true;

            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Authorization", "Bearer " + Program.LogInToken);

                String response = webClient.DownloadString(ServerAPIURL + "/api/v2/admin/accounts/users/profiles=" + GlobalUUID + "/configurations");

                String[] RecivedMatrix = response.Split('|');

                ListaDeConfiguraciones.Rows.Clear();

                if (RecivedMatrix[0] == "200")
                {
                    String[] UserList = response.Split('\n');

                    foreach (String User in UserList)
                    {
                        if (User != "")
                        {
                            RecivedMatrix = User.Split('|');

                            String code = RecivedMatrix[0];
                            String uuid = RecivedMatrix[1];
                            String Par = RecivedMatrix[2];
                            String Var = RecivedMatrix[3];

                            if (code == "200")
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(ListaDeConfiguraciones);

                                row.Height = 40;

                                row.Cells[0].Value = uuid;
                                row.Cells[1].Value = Par;
                                row.Cells[2].Value = Var;
                                ListaDeConfiguraciones.Rows.Add(row);
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

        private void SubPanel_unload(object sender, FormClosedEventArgs e)
        {
            this.MainPanel.Visible = true;
            SubPanel.Visible = false;
            SubPanel.Dispose();
            SubPanel = null;
        }
        private void LoadConfigsKeys()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Authorization", "Bearer " + Program.LogInToken);

                String response = webClient.DownloadString(ServerAPIURL + "/api/v2/dictionary/configurations?profileuuid=" + GlobalUUID);

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
                            String key = RecivedMatrix[1];

                            if (code == "200")
                            {
                                this.Parametro.Items.Add(key);
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            // Application.DoEvents();
        }

        private void Administrator_Resize(object sender, EventArgs e) {
            WaitAnimation.Top = (this.Height / 2) - (WaitAnimation.Height / 2);
            WaitAnimation.Left = (this.Width / 2) - (WaitAnimation.Width / 2);

            if (this.Width < 1000)
                this.Route.Visible = false;
            else
                this.Route.Visible = true;
        }

        private async void AgregarParametro()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                MultipartFormDataContent form = new MultipartFormDataContent();
                HttpResponseMessage response;

                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.LogInToken.Trim());
                form.Add(new StringContent(this.Parametro.Text.Trim() + "=" + this.Valor.Text.Trim()), "value");

                response = await httpClient.PostAsync(ServerAPIURL + "/api/v2/admin/accounts/users/profiles=" + GlobalUUID + "/configurations", form);

                response.EnsureSuccessStatusCode();
                httpClient.Dispose();
                String[] RecivedMatrix = response.Content.ReadAsStringAsync().Result.Split('|');

                if (RecivedMatrix[0] != "200")
                    MessageBox.Show(RecivedMatrix[1], "Atención", MessageBoxButtons.OK);
                else
                {
                    LoadConfigs();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void Borrar(String UUID)
        {
            try
            {
                if (MessageBox.Show("Se dispone a borrar un parametros de configuración, al hacerlo el parametro tomara el valor por defecto del sistema, ¿quiere continuar?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    WebClient webClient = new WebClient();


                    webClient.Headers.Add("Authorization", "Bearer " + Program.LogInToken.Trim());
                    String response = Encoding.ASCII.GetString(webClient.UploadValues(ServerAPIURL + "/api/v2/admin/accounts/users/profiles/configurations=" + UUID, "DELETE", new System.Collections.Specialized.NameValueCollection()));

                    String[] RecivedMatrix = response.Split('|');

                    if (RecivedMatrix[0] != "200")
                        MessageBox.Show(RecivedMatrix[1], "Atención", MessageBoxButtons.OK);
                    else
                    {
                        LoadConfigs();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void ListaDeDetecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String UUID = "";

                if (e.ColumnIndex == 3 && e.RowIndex > -1)
                {
                    try
                    {
                        if (e.RowIndex > -1)
                        {
                            UUID = this.ListaDeConfiguraciones.Rows[e.RowIndex].Cells[0].Value.ToString();
                        }

                        Borrar(UUID);
                    }
                    catch { }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            AgregarParametro();
        }

        private void Button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            timer1.Enabled = false;
            LoadConfigs();
            LoadConfigsKeys();
        }

    }
}
