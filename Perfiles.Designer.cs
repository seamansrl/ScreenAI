namespace Horus
{
    partial class Perfiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfiles));
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.ListaDePerfiles = new System.Windows.Forms.DataGridView();
            this.PERFIL_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLOQUEADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GESTIONAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CAMBIAR_NOMBRE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SeperiorPanel = new System.Windows.Forms.Panel();
            this.LineaPanelV = new System.Windows.Forms.Panel();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.Button2 = new System.Windows.Forms.Button();
            this.Route = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.Leyenda = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.CloudIcon = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Label();
            this.FondoMovil = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WaitAnimation = new System.Windows.Forms.PictureBox();
            this.CentralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDePerfiles)).BeginInit();
            this.SeperiorPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FondoMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // CentralPanel
            // 
            this.CentralPanel.BackColor = System.Drawing.Color.White;
            this.CentralPanel.Controls.Add(this.ListaDePerfiles);
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(250, 206);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Padding = new System.Windows.Forms.Padding(30);
            this.CentralPanel.Size = new System.Drawing.Size(1025, 494);
            this.CentralPanel.TabIndex = 3;
            // 
            // ListaDePerfiles
            // 
            this.ListaDePerfiles.AllowUserToAddRows = false;
            this.ListaDePerfiles.AllowUserToDeleteRows = false;
            this.ListaDePerfiles.BackgroundColor = System.Drawing.Color.White;
            this.ListaDePerfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaDePerfiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListaDePerfiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaDePerfiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaDePerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaDePerfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PERFIL_NAME,
            this.UUID,
            this.BLOQUEADO,
            this.Tipo,
            this.GESTIONAR,
            this.ELIMINAR,
            this.CAMBIAR_NOMBRE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaDePerfiles.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaDePerfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaDePerfiles.EnableHeadersVisualStyles = false;
            this.ListaDePerfiles.GridColor = System.Drawing.Color.LightBlue;
            this.ListaDePerfiles.Location = new System.Drawing.Point(30, 30);
            this.ListaDePerfiles.MultiSelect = false;
            this.ListaDePerfiles.Name = "ListaDePerfiles";
            this.ListaDePerfiles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaDePerfiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListaDePerfiles.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ListaDePerfiles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaDePerfiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListaDePerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaDePerfiles.ShowCellErrors = false;
            this.ListaDePerfiles.ShowCellToolTips = false;
            this.ListaDePerfiles.ShowEditingIcon = false;
            this.ListaDePerfiles.ShowRowErrors = false;
            this.ListaDePerfiles.Size = new System.Drawing.Size(965, 434);
            this.ListaDePerfiles.TabIndex = 0;
            this.ListaDePerfiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaDePerfiles_CellContentClick);
            // 
            // PERFIL_NAME
            // 
            this.PERFIL_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERFIL_NAME.Frozen = true;
            this.PERFIL_NAME.HeaderText = "PERFIL";
            this.PERFIL_NAME.MinimumWidth = 300;
            this.PERFIL_NAME.Name = "PERFIL_NAME";
            this.PERFIL_NAME.ReadOnly = true;
            this.PERFIL_NAME.Width = 300;
            // 
            // UUID
            // 
            this.UUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UUID.Frozen = true;
            this.UUID.HeaderText = "UUID DEL PERFIL";
            this.UUID.Name = "UUID";
            this.UUID.ReadOnly = true;
            this.UUID.Visible = false;
            // 
            // BLOQUEADO
            // 
            this.BLOQUEADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BLOQUEADO.Frozen = true;
            this.BLOQUEADO.HeaderText = "BLOQUEADO";
            this.BLOQUEADO.Name = "BLOQUEADO";
            this.BLOQUEADO.ReadOnly = true;
            this.BLOQUEADO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BLOQUEADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BLOQUEADO.Width = 126;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tipo.Frozen = true;
            this.Tipo.HeaderText = "TIPO DE PERFIL";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            // 
            // GESTIONAR
            // 
            this.GESTIONAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GESTIONAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GESTIONAR.Frozen = true;
            this.GESTIONAR.HeaderText = "";
            this.GESTIONAR.Name = "GESTIONAR";
            this.GESTIONAR.ReadOnly = true;
            this.GESTIONAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GESTIONAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GESTIONAR.Text = "GESTIONAR";
            this.GESTIONAR.UseColumnTextForButtonValue = true;
            this.GESTIONAR.Width = 18;
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
            // CAMBIAR_NOMBRE
            // 
            this.CAMBIAR_NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CAMBIAR_NOMBRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAMBIAR_NOMBRE.Frozen = true;
            this.CAMBIAR_NOMBRE.HeaderText = "";
            this.CAMBIAR_NOMBRE.Name = "CAMBIAR_NOMBRE";
            this.CAMBIAR_NOMBRE.ReadOnly = true;
            this.CAMBIAR_NOMBRE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CAMBIAR_NOMBRE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CAMBIAR_NOMBRE.Text = "CAMBIAR NOMBRE";
            this.CAMBIAR_NOMBRE.UseColumnTextForButtonValue = true;
            this.CAMBIAR_NOMBRE.Width = 18;
            // 
            // SeperiorPanel
            // 
            this.SeperiorPanel.Controls.Add(this.LineaPanelV);
            this.SeperiorPanel.Controls.Add(this.LinePanel);
            this.SeperiorPanel.Controls.Add(this.Button2);
            this.SeperiorPanel.Controls.Add(this.Route);
            this.SeperiorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeperiorPanel.Location = new System.Drawing.Point(250, 0);
            this.SeperiorPanel.Name = "SeperiorPanel";
            this.SeperiorPanel.Size = new System.Drawing.Size(1025, 56);
            this.SeperiorPanel.TabIndex = 5;
            // 
            // LineaPanelV
            // 
            this.LineaPanelV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaPanelV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LineaPanelV.Location = new System.Drawing.Point(854, 0);
            this.LineaPanelV.Name = "LineaPanelV";
            this.LineaPanelV.Size = new System.Drawing.Size(1, 56);
            this.LineaPanelV.TabIndex = 8;
            // 
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LinePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LinePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LinePanel.Location = new System.Drawing.Point(0, 55);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(1025, 1);
            this.LinePanel.TabIndex = 6;
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(112)))), ((int)(((byte)(178)))));
            this.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(112)))), ((int)(((byte)(178)))));
            this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(112)))), ((int)(((byte)(178)))));
            this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(677, 1);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(163, 55);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Agregar perfil";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Route
            // 
            this.Route.AutoSize = true;
            this.Route.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Route.ForeColor = System.Drawing.Color.Gray;
            this.Route.Location = new System.Drawing.Point(24, 21);
            this.Route.Name = "Route";
            this.Route.Size = new System.Drawing.Size(204, 17);
            this.Route.TabIndex = 7;
            this.Route.Text = "Mi Cuenta / Usuarios / Perfiles";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CentralPanel);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Controls.Add(this.SeperiorPanel);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1275, 700);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Visible = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.HeaderPanel.Controls.Add(this.Icon);
            this.HeaderPanel.Controls.Add(this.Leyenda);
            this.HeaderPanel.Controls.Add(this.Titulo);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(250, 56);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1025, 150);
            this.HeaderPanel.TabIndex = 6;
            // 
            // Icon
            // 
            this.Icon.Image = ((System.Drawing.Image)(resources.GetObject("Icon.Image")));
            this.Icon.Location = new System.Drawing.Point(6, 6);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(116, 145);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon.TabIndex = 32;
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
            this.Leyenda.Size = new System.Drawing.Size(832, 83);
            this.Leyenda.TabIndex = 29;
            this.Leyenda.Text = resources.GetString("Leyenda.Text");
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Titulo.Location = new System.Drawing.Point(132, 25);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(170, 22);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Perfil de servicio ";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuPanel.Controls.Add(this.CloudIcon);
            this.MenuPanel.Controls.Add(this.Button1);
            this.MenuPanel.Controls.Add(this.TitlePanel);
            this.MenuPanel.Controls.Add(this.FondoMovil);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(250, 700);
            this.MenuPanel.TabIndex = 5;
            // 
            // CloudIcon
            // 
            this.CloudIcon.Image = global::Horus.Properties.Resources.CloudIconNeg;
            this.CloudIcon.Location = new System.Drawing.Point(115, 12);
            this.CloudIcon.Name = "CloudIcon";
            this.CloudIcon.Size = new System.Drawing.Size(26, 26);
            this.CloudIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloudIcon.TabIndex = 28;
            this.CloudIcon.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(0, 56);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(250, 48);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "    << Volver";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
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
            this.FondoMovil.Location = new System.Drawing.Point(0, 100);
            this.FondoMovil.Name = "FondoMovil";
            this.FondoMovil.Size = new System.Drawing.Size(251, 600);
            this.FondoMovil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FondoMovil.TabIndex = 9;
            this.FondoMovil.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // WaitAnimation
            // 
            this.WaitAnimation.Image = global::Horus.Properties.Resources.Loading;
            this.WaitAnimation.Location = new System.Drawing.Point(665, 270);
            this.WaitAnimation.Name = "WaitAnimation";
            this.WaitAnimation.Size = new System.Drawing.Size(160, 160);
            this.WaitAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WaitAnimation.TabIndex = 4;
            this.WaitAnimation.TabStop = false;
            // 
            // Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1275, 700);
            this.Controls.Add(this.WaitAnimation);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Perfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfiles";
            this.Resize += new System.EventHandler(this.Perfiles_Resize);
            this.CentralPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaDePerfiles)).EndInit();
            this.SeperiorPanel.ResumeLayout(false);
            this.SeperiorPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FondoMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitAnimation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.DataGridView ListaDePerfiles;
        private System.Windows.Forms.Panel SeperiorPanel;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.Label Route;
        private System.Windows.Forms.Panel LineaPanelV;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label TitlePanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox WaitAnimation;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.TextBox Leyenda;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox  Icon;
        private System.Windows.Forms.PictureBox CloudIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERFIL_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UUID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BLOQUEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewButtonColumn GESTIONAR;
        private System.Windows.Forms.DataGridViewButtonColumn ELIMINAR;
        private System.Windows.Forms.DataGridViewButtonColumn CAMBIAR_NOMBRE;
        private System.Windows.Forms.PictureBox FondoMovil;
    }
}