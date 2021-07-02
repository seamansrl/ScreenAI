namespace Horus {
    partial class Rostros {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListaDeDetecciones = new System.Windows.Forms.DataGridView();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERFILES = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MODIFICAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SeperiorPanel = new System.Windows.Forms.Panel();
            this.LineaPanelV = new System.Windows.Forms.Panel();
            this.Route = new System.Windows.Forms.Label();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.Alta = new System.Windows.Forms.Button();
            this.Config = new System.Windows.Forms.Button();
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SubPanel1 = new System.Windows.Forms.Panel();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.Leyenda = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.CloudIcon = new System.Windows.Forms.PictureBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Label();
            this.FondoMovil = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WaitAnimation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDeDetecciones)).BeginInit();
            this.SeperiorPanel.SuspendLayout();
            this.CentralPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SubPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FondoMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaDeDetecciones
            // 
            this.ListaDeDetecciones.AllowUserToAddRows = false;
            this.ListaDeDetecciones.AllowUserToDeleteRows = false;
            this.ListaDeDetecciones.BackgroundColor = System.Drawing.Color.White;
            this.ListaDeDetecciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaDeDetecciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListaDeDetecciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaDeDetecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaDeDetecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaDeDetecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USUARIO,
            this.UUID,
            this.PERFILES,
            this.ELIMINAR,
            this.MODIFICAR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaDeDetecciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaDeDetecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaDeDetecciones.EnableHeadersVisualStyles = false;
            this.ListaDeDetecciones.GridColor = System.Drawing.Color.LightBlue;
            this.ListaDeDetecciones.Location = new System.Drawing.Point(30, 30);
            this.ListaDeDetecciones.MultiSelect = false;
            this.ListaDeDetecciones.Name = "ListaDeDetecciones";
            this.ListaDeDetecciones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaDeDetecciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListaDeDetecciones.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ListaDeDetecciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaDeDetecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaDeDetecciones.ShowCellErrors = false;
            this.ListaDeDetecciones.ShowCellToolTips = false;
            this.ListaDeDetecciones.ShowEditingIcon = false;
            this.ListaDeDetecciones.ShowRowErrors = false;
            this.ListaDeDetecciones.Size = new System.Drawing.Size(952, 436);
            this.ListaDeDetecciones.TabIndex = 0;
            this.ListaDeDetecciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaDeDetecciones_CellContentClick);
            // 
            // USUARIO
            // 
            this.USUARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.USUARIO.Frozen = true;
            this.USUARIO.HeaderText = "NOMBRE";
            this.USUARIO.MinimumWidth = 300;
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
            this.USUARIO.Width = 300;
            // 
            // UUID
            // 
            this.UUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UUID.Frozen = true;
            this.UUID.HeaderText = "UUID";
            this.UUID.Name = "UUID";
            this.UUID.ReadOnly = true;
            this.UUID.Visible = false;
            // 
            // PERFILES
            // 
            this.PERFILES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERFILES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PERFILES.Frozen = true;
            this.PERFILES.HeaderText = "";
            this.PERFILES.Name = "PERFILES";
            this.PERFILES.ReadOnly = true;
            this.PERFILES.Text = "REGISTRO BIOMETRICO";
            this.PERFILES.UseColumnTextForButtonValue = true;
            this.PERFILES.Width = 5;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ELIMINAR.Frozen = true;
            this.ELIMINAR.HeaderText = "";
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            this.ELIMINAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ELIMINAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ELIMINAR.Text = "ELIMINAR";
            this.ELIMINAR.UseColumnTextForButtonValue = true;
            this.ELIMINAR.Width = 18;
            // 
            // MODIFICAR
            // 
            this.MODIFICAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MODIFICAR.HeaderText = "";
            this.MODIFICAR.Name = "MODIFICAR";
            this.MODIFICAR.ReadOnly = true;
            this.MODIFICAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MODIFICAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MODIFICAR.Text = "MODIFICAR";
            this.MODIFICAR.UseColumnTextForButtonValue = true;
            this.MODIFICAR.Width = 18;
            // 
            // SeperiorPanel
            // 
            this.SeperiorPanel.Controls.Add(this.LineaPanelV);
            this.SeperiorPanel.Controls.Add(this.Route);
            this.SeperiorPanel.Controls.Add(this.LinePanel);
            this.SeperiorPanel.Controls.Add(this.Alta);
            this.SeperiorPanel.Controls.Add(this.Config);
            this.SeperiorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeperiorPanel.Location = new System.Drawing.Point(250, 0);
            this.SeperiorPanel.Name = "SeperiorPanel";
            this.SeperiorPanel.Size = new System.Drawing.Size(1012, 56);
            this.SeperiorPanel.TabIndex = 7;
            // 
            // LineaPanelV
            // 
            this.LineaPanelV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaPanelV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LineaPanelV.Location = new System.Drawing.Point(841, 0);
            this.LineaPanelV.Name = "LineaPanelV";
            this.LineaPanelV.Size = new System.Drawing.Size(1, 56);
            this.LineaPanelV.TabIndex = 8;
            // 
            // Route
            // 
            this.Route.AutoSize = true;
            this.Route.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Route.ForeColor = System.Drawing.Color.Gray;
            this.Route.Location = new System.Drawing.Point(24, 21);
            this.Route.Name = "Route";
            this.Route.Size = new System.Drawing.Size(145, 17);
            this.Route.TabIndex = 7;
            this.Route.Text = "... / Perfiles / Rostros";
            // 
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LinePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LinePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LinePanel.Location = new System.Drawing.Point(0, 55);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(1012, 1);
            this.LinePanel.TabIndex = 6;
            // 
            // Alta
            // 
            this.Alta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Alta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(112)))), ((int)(((byte)(178)))));
            this.Alta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(112)))), ((int)(((byte)(178)))));
            this.Alta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(112)))), ((int)(((byte)(178)))));
            this.Alta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.Alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alta.ForeColor = System.Drawing.Color.White;
            this.Alta.Image = global::Horus.Properties.Resources.Add1;
            this.Alta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Alta.Location = new System.Drawing.Point(509, 1);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(180, 55);
            this.Alta.TabIndex = 2;
            this.Alta.Text = "    Alta de rostro";
            this.Alta.UseVisualStyleBackColor = false;
            this.Alta.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Config
            // 
            this.Config.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(112)))), ((int)(((byte)(178)))));
            this.Config.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(112)))), ((int)(((byte)(178)))));
            this.Config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(112)))), ((int)(((byte)(178)))));
            this.Config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Config.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Config.ForeColor = System.Drawing.Color.White;
            this.Config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Config.Location = new System.Drawing.Point(693, 1);
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(143, 55);
            this.Config.TabIndex = 10;
            this.Config.Text = "  Configuiración";
            this.Config.UseVisualStyleBackColor = false;
            this.Config.Click += new System.EventHandler(this.Button8_Click);
            // 
            // CentralPanel
            // 
            this.CentralPanel.BackColor = System.Drawing.Color.White;
            this.CentralPanel.Controls.Add(this.ListaDeDetecciones);
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(250, 204);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Padding = new System.Windows.Forms.Padding(30);
            this.CentralPanel.Size = new System.Drawing.Size(1012, 496);
            this.CentralPanel.TabIndex = 8;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CentralPanel);
            this.MainPanel.Controls.Add(this.SubPanel1);
            this.MainPanel.Controls.Add(this.SeperiorPanel);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1262, 700);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Visible = false;
            // 
            // SubPanel1
            // 
            this.SubPanel1.BackColor = System.Drawing.Color.White;
            this.SubPanel1.Controls.Add(this.Icon);
            this.SubPanel1.Controls.Add(this.Leyenda);
            this.SubPanel1.Controls.Add(this.Titulo);
            this.SubPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanel1.Location = new System.Drawing.Point(250, 56);
            this.SubPanel1.Name = "SubPanel1";
            this.SubPanel1.Size = new System.Drawing.Size(1012, 148);
            this.SubPanel1.TabIndex = 9;
            // 
            // Icon
            // 
            this.Icon.Image = global::Horus.Properties.Resources.FacesIcon;
            this.Icon.Location = new System.Drawing.Point(6, 6);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(116, 145);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon.TabIndex = 33;
            this.Icon.TabStop = false;
            // 
            // Leyenda
            // 
            this.Leyenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Leyenda.BackColor = System.Drawing.Color.White;
            this.Leyenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Leyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leyenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Leyenda.Location = new System.Drawing.Point(163, 53);
            this.Leyenda.Multiline = true;
            this.Leyenda.Name = "Leyenda";
            this.Leyenda.ReadOnly = true;
            this.Leyenda.Size = new System.Drawing.Size(819, 83);
            this.Leyenda.TabIndex = 29;
            this.Leyenda.Text = "A continuación se lista a todas los rostros registradas en el sistema bajo el pre" +
    "sente perfil.";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Titulo.Location = new System.Drawing.Point(132, 25);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(83, 22);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Rostros";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.MenuPanel.Controls.Add(this.CloudIcon);
            this.MenuPanel.Controls.Add(this.Button3);
            this.MenuPanel.Controls.Add(this.TitlePanel);
            this.MenuPanel.Controls.Add(this.FondoMovil);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(250, 700);
            this.MenuPanel.TabIndex = 6;
            // 
            // CloudIcon
            // 
            this.CloudIcon.Image = global::Horus.Properties.Resources.CloudIconNeg;
            this.CloudIcon.Location = new System.Drawing.Point(114, 13);
            this.CloudIcon.Name = "CloudIcon";
            this.CloudIcon.Size = new System.Drawing.Size(26, 26);
            this.CloudIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloudIcon.TabIndex = 28;
            this.CloudIcon.TabStop = false;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(0, 58);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(250, 48);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "        << Volver";
            this.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.AutoSize = true;
            this.TitlePanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TitlePanel.Location = new System.Drawing.Point(31, 19);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(70, 16);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.Text = "Screen AI";
            // 
            // FondoMovil
            // 
            this.FondoMovil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FondoMovil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FondoMovil.Image = global::Horus.Properties.Resources.Perfiles;
            this.FondoMovil.Location = new System.Drawing.Point(0, 99);
            this.FondoMovil.Name = "FondoMovil";
            this.FondoMovil.Size = new System.Drawing.Size(251, 600);
            this.FondoMovil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FondoMovil.TabIndex = 9;
            this.FondoMovil.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // WaitAnimation
            // 
            this.WaitAnimation.Image = global::Horus.Properties.Resources.Loading;
            this.WaitAnimation.Location = new System.Drawing.Point(629, 284);
            this.WaitAnimation.Name = "WaitAnimation";
            this.WaitAnimation.Size = new System.Drawing.Size(160, 160);
            this.WaitAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WaitAnimation.TabIndex = 3;
            this.WaitAnimation.TabStop = false;
            // 
            // Rostros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1262, 700);
            this.Controls.Add(this.WaitAnimation);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rostros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detecciones";
            this.Resize += new System.EventHandler(this.Administrator_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ListaDeDetecciones)).EndInit();
            this.SeperiorPanel.ResumeLayout(false);
            this.SeperiorPanel.PerformLayout();
            this.CentralPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.SubPanel1.ResumeLayout(false);
            this.SubPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FondoMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitAnimation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ListaDeDetecciones;
        private System.Windows.Forms.Panel SeperiorPanel;
        private System.Windows.Forms.Panel LineaPanelV;
        private System.Windows.Forms.Label Route;
        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.Button Config;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Label TitlePanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox WaitAnimation;
        private System.Windows.Forms.Panel SubPanel1;
        private System.Windows.Forms.TextBox Leyenda;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox  Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UUID;
        private System.Windows.Forms.DataGridViewButtonColumn PERFILES;
        private System.Windows.Forms.DataGridViewButtonColumn ELIMINAR;
        private System.Windows.Forms.DataGridViewButtonColumn MODIFICAR;
        private System.Windows.Forms.PictureBox CloudIcon;
        private System.Windows.Forms.PictureBox FondoMovil;
    }
}