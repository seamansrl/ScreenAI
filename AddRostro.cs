using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Horus
{
    public partial class AddRostro : Form
    {
        String ServerAPIURL = "" + Program.Server;
        String GlobalUUID = "";
        String Valor = "";

        private async void AgregarDeteccion()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                MultipartFormDataContent form = new MultipartFormDataContent();
                HttpResponseMessage response;

                Valor = this.Nombre.Text.Trim();

                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.LogInToken.Trim());
                form.Add(new StringContent(this.Nombre.Text.Trim()), "name");
                form.Add(new StringContent(Valor.Trim()), "value");

                response = await httpClient.PostAsync(ServerAPIURL + "/api/v2/admin/accounts/users/profiles=" + GlobalUUID + "/detections", form);

                response.EnsureSuccessStatusCode();
                httpClient.Dispose();
                String[] RecivedMatrix = response.Content.ReadAsStringAsync().Result.Split('|');

                if (RecivedMatrix[0] != "201")
                    MessageBox.Show(RecivedMatrix[1], "Atención", MessageBoxButtons.OK);
                else
                    this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }


        public AddRostro(String UUID)
        {
            InitializeComponent();

            GlobalUUID = UUID;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            AgregarDeteccion();
        }

        private void Button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AddDetection_Load(object sender, EventArgs e)
        {
            this.Nombre.Focus();
        }
    }
}
