using System;
using System.Net;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace Horus
{
    public partial class ModifyRostro : Form
    {
        String ServerAPIURL = "" + Program.Server;
        String GlobalUUID = "";
        String GlobalProfileUUID = "";
        String Valor = "";

        public ModifyRostro(String UUID, String ProfileUUID)
        {
            InitializeComponent();

            GlobalUUID = UUID;
            GlobalProfileUUID = ProfileUUID;
        }
        private void LoadDetectionName()
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("Authorization", "Bearer " + Program.LogInToken.Trim());

            String response = webClient.DownloadString(ServerAPIURL + "/api/v2/admin/accounts/users/profiles=" + GlobalProfileUUID + "/detections=" + GlobalUUID + "/name");

            String[] RecivedMatrix = response.Split('|');

            if (RecivedMatrix[0] == "200")
            {
                this.Nombre.Text = RecivedMatrix[1];
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Aceptar_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            MultipartFormDataContent form = new MultipartFormDataContent();
            HttpResponseMessage response;

            Valor = this.Nombre.Text.Trim();

            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.LogInToken.Trim());
            form.Add(new StringContent(this.Nombre.Text.Trim()), "name");

            response = await httpClient.PutAsync(ServerAPIURL + "/api/v2/admin/accounts/users/profiles=" + GlobalProfileUUID + "/detections=" + GlobalUUID, form);

            response.EnsureSuccessStatusCode();
            httpClient.Dispose();
            String[] RecivedMatrix = response.Content.ReadAsStringAsync().Result.Split('|');

            if (RecivedMatrix[0] != "200")
                MessageBox.Show(RecivedMatrix[1], "Atención", MessageBoxButtons.OK);
            else
            {
                HttpClient httpClient1 = new HttpClient();
                MultipartFormDataContent form1 = new MultipartFormDataContent();
                HttpResponseMessage response1;

                httpClient1.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.LogInToken.Trim());
                form1.Add(new StringContent(Valor.Trim()), "value");

                response1 = await httpClient1.PutAsync(ServerAPIURL + "/api/v2/admin/accounts/users/profiles=" + GlobalProfileUUID + "/detections=" + GlobalUUID, form1);

                response.EnsureSuccessStatusCode();
                httpClient.Dispose();
                String[] RecivedMatrix1 = response1.Content.ReadAsStringAsync().Result.Split('|');

                if (RecivedMatrix1[0] != "200")
                    MessageBox.Show(RecivedMatrix1[1], "Atención", MessageBoxButtons.OK);
                else
                {
                    this.Close();
                }
            }
        }

        private void ModifyDetection_Load(object sender, EventArgs e)
        {
            LoadDetectionName();

            this.Nombre.Focus();
        }

        private void Button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
