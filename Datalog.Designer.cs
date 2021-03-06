namespace Horus
{
    partial class Datalog
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
            this.ListaDeDatalog = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMESTAMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeperiorPanel = new System.Windows.Forms.Panel();
            this.Route = new System.Windows.Forms.Label();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.LogoProvider = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SubPanel1 = new System.Windows.Forms.Panel();
            this.Leyenda = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.CloudIcon = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Label();
            this.FondoMovil = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WaitAnimation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDeDatalog)).BeginInit();
            this.SeperiorPanel.SuspendLayout();
            this.CentralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoProvider)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SubPanel1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FondoMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaDeDatalog
            // 
            this.ListaDeDatalog.AllowUserToAddRows = false;
            this.ListaDeDatalog.AllowUserToDeleteRows = false;
            this.ListaDeDatalog.BackgroundColor = System.Drawing.Color.White;
            this.ListaDeDatalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaDeDatalog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListaDeDatalog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaDeDatalog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaDeDatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaDeDatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TIMESTAMP,
            this.VALUE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaDeDatalog.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaDeDatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaDeDatalog.EnableHeadersVisualStyles = false;
            this.ListaDeDatalog.GridColor = System.Drawing.Color.LightBlue;
            this.ListaDeDatalog.Location = new System.Drawing.Point(30, 30);
            this.ListaDeDatalog.MultiSelect = false;
            this.ListaDeDatalog.Name = "ListaDeDatalog";
            this.ListaDeDatalog.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaDeDatalog.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListaDeDatalog.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ListaDeDatalog.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaDeDatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaDeDatalog.ShowCellErrors = false;
            this.ListaDeDatalog.ShowCellToolTips = false;
            this.ListaDeDatalog.ShowEditingIcon = false;
            this.ListaDeDatalog.ShowRowErrors = false;
            this.ListaDeDatalog.Size = new System.Drawing.Size(952, 468);
            this.ListaDeDatalog.TabIndex = 0;
            this.ListaDeDatalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaDeDatalog_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.Frozen = true;
            this.ID.HeaderText = "UUID";
            this.ID.MinimumWidth = 20;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // TIMESTAMP
            // 
            this.TIMESTAMP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIMESTAMP.Frozen = true;
            this.TIMESTAMP.HeaderText = "TIMESTAMP";
            this.TIMESTAMP.MinimumWidth = 150;
            this.TIMESTAMP.Name = "TIMESTAMP";
            this.TIMESTAMP.ReadOnly = true;
            this.TIMESTAMP.Width = 150;
            // 
            // VALUE
            // 
            this.VALUE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VALUE.Frozen = true;
            this.VALUE.HeaderText = "VALUE";
            this.VALUE.MinimumWidth = 400;
            this.VALUE.Name = "VALUE";
            this.VALUE.ReadOnly = true;
            this.VALUE.Width = 400;
            // 
            // SeperiorPanel
            // 
            this.SeperiorPanel.Controls.Add(this.Route);
            this.SeperiorPanel.Controls.Add(this.LinePanel);
            this.SeperiorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeperiorPanel.Location = new System.Drawing.Point(250, 0);
            this.SeperiorPanel.Name = "SeperiorPanel";
            this.SeperiorPanel.Size = new System.Drawing.Size(1012, 56);
            this.SeperiorPanel.TabIndex = 7;
            // 
            // Route
            // 
            this.Route.AutoSize = true;
            this.Route.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Route.ForeColor = System.Drawing.Color.Gray;
            this.Route.Location = new System.Drawing.Point(24, 21);
            this.Route.Name = "Route";
            this.Route.Size = new System.Drawing.Size(312, 17);
            this.Route.TabIndex = 7;
            this.Route.Text = "... / Perfiles / Detecciones / Camaras / Historial";
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
            // CentralPanel
            // 
            this.CentralPanel.BackColor = System.Drawing.Color.White;
            this.CentralPanel.Controls.Add(this.LogoProvider);
            this.CentralPanel.Controls.Add(this.ListaDeDatalog);
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(250, 172);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Padding = new System.Windows.Forms.Padding(30);
            this.CentralPanel.Size = new System.Drawing.Size(1012, 528);
            this.CentralPanel.TabIndex = 8;
            // 
            // LogoProvider
            // 
            this.LogoProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoProvider.BackColor = System.Drawing.Color.White;
            this.LogoProvider.Location = new System.Drawing.Point(5, 396);
            this.LogoProvider.Name = "LogoProvider";
            this.LogoProvider.Size = new System.Drawing.Size(223, 56);
            this.LogoProvider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoProvider.TabIndex = 32;
            this.LogoProvider.TabStop = false;
            this.LogoProvider.Visible = false;
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
            this.SubPanel1.Controls.Add(this.Leyenda);
            this.SubPanel1.Controls.Add(this.Titulo);
            this.SubPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanel1.Location = new System.Drawing.Point(250, 56);
            this.SubPanel1.Name = "SubPanel1";
            this.SubPanel1.Size = new System.Drawing.Size(1012, 116);
            this.SubPanel1.TabIndex = 9;
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
            this.Leyenda.Location = new System.Drawing.Point(53, 59);
            this.Leyenda.Multiline = true;
            this.Leyenda.Name = "Leyenda";
            this.Leyenda.ReadOnly = true;
            this.Leyenda.Size = new System.Drawing.Size(947, 39);
            this.Leyenda.TabIndex = 29;
            this.Leyenda.Text = "A continuación se presenta una lista de las ultimas detecciones obtenidas por el " +
    "dispositivo biometrico";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Titulo.Location = new System.Drawing.Point(26, 26);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(86, 22);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Historial";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(3)))));
            this.MenuPanel.Controls.Add(this.CloudIcon);
            this.MenuPanel.Controls.Add(this.Button1);
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
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
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
            this.FondoMovil.Location = new System.Drawing.Point(0, 101);
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
            // Datalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1262, 700);
            this.Controls.Add(this.WaitAnimation);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Datalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datalog";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.Resize += new System.EventHandler(this.Administrator_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ListaDeDatalog)).EndInit();
            this.SeperiorPanel.ResumeLayout(false);
            this.SeperiorPanel.PerformLayout();
            this.CentralPanel.ResumeLayout(false);
            this.CentralPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoProvider)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.SubPanel1.ResumeLayout(false);
            this.SubPanel1.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FondoMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitAnimation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ListaDeDatalog;
        private System.Windows.Forms.Panel SeperiorPanel;
        private System.Windows.Forms.Label Route;
        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label TitlePanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox WaitAnimation;
        private System.Windows.Forms.PictureBox FondoMovil;
        private System.Windows.Forms.Panel SubPanel1;
        private System.Windows.Forms.TextBox Leyenda;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox CloudIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMESTAMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALUE;
        public System.Windows.Forms.PictureBox LogoProvider;
    }
}