using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace Horus {
    public partial class AddProfile : Form {
        String ServerAPIURL = "" + Program.Server;
        String GlobalUUID = "";

        public AddProfile(String UUID) {
            InitializeComponent();

            GlobalUUID = UUID;
        }

        private async void AddNewProfile() {
            try {
                HttpClient httpClient = new HttpClient();
                MultipartFormDataContent form = new MultipartFormDataContent();
                HttpResponseMessage response;

                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.LogInToken.Trim());
                form.Add(new StringContent(this.Tipo.SelectedIndex.ToString()), "profiletype");
                form.Add(new StringContent(this.Perfil.Text.Trim()), "profilename");
                form.Add(new StringContent(this.CatalogoCNN.Text.Trim()), "catalog");

                response = await httpClient.PostAsync(ServerAPIURL + "/api/v2/admin/accounts/users=" + GlobalUUID + "/profiles", form);

                response.EnsureSuccessStatusCode();
                httpClient.Dispose();
                String[] RecivedMatrix = response.Content.ReadAsStringAsync().Result.Split('|');

                if (RecivedMatrix[0] != "201")
                    MessageBox.Show(RecivedMatrix[1], "Atención", MessageBoxButtons.OK);
                else
                    this.Close();
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void AddProfilesType() {
            try {
                WebClient webClient = new WebClient();
                String response = webClient.DownloadString(ServerAPIURL + "/api/v2/dictionary/profilestype");

                String[] RecivedMatrix = response.Split('|');

                this.Tipo.Items.Clear();

                if (RecivedMatrix[0] == "200") {
                    String[] UserList = response.Split('\n');

                    foreach (String User in UserList) {
                        if (User != "") {
                            RecivedMatrix = User.Split('|');

                            String code = RecivedMatrix[0];
                            String id = RecivedMatrix[1];
                            String name = RecivedMatrix[2];

                            if (code == "200") {
                                this.Tipo.Items.Add(name);
                                this.Tipo.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void AddCNNCatalogs() {
            try {
                WebClient webClient = new WebClient();
                String response = webClient.DownloadString(ServerAPIURL + "/api/v2/dictionary/cnncatalogs");

                String[] RecivedMatrix = response.Split('|');

                this.CatalogoCNN.Items.Clear();

                if (RecivedMatrix[0] == "200") {
                    String[] UserList = response.Split('\n');

                    foreach (String User in UserList) {
                        if (User != "") {
                            RecivedMatrix = User.Split('|');

                            String code = RecivedMatrix[0];
                            String id = RecivedMatrix[1];
                            String name = RecivedMatrix[2];

                            if (code == "200") {
                                this.CatalogoCNN.Items.Add(name);
                                this.CatalogoCNN.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e) {
            AddNewProfile();
        }

        private void AddProfile_Load(object sender, EventArgs e) {
            AddProfilesType();
            AddCNNCatalogs();
        }

        private void Tipo_SelectedIndexChanged(object sender, EventArgs e) {
            if (Tipo.SelectedIndex == 1)
                CatalogoCNN.Enabled = true;
            else
                CatalogoCNN.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}