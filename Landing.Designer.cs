﻿namespace Horus
{
    partial class Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LeyendaSeaMan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Clave = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Leyenda = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Alta = new System.Windows.Forms.Button();
            this.Fondo = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.CloudIcon = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WaitAnimation = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Streams = new System.Windows.Forms.TabControl();
            this.NewStream = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.LoginPanel);
            this.MainPanel.Controls.Add(this.Fondo);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1184, 761);
            this.MainPanel.TabIndex = 29;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Controls.Add(this.LeyendaSeaMan);
            this.LoginPanel.Controls.Add(this.panel1);
            this.LoginPanel.Controls.Add(this.Alta);
            this.LoginPanel.Location = new System.Drawing.Point(0, 222);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(683, 301);
            this.LoginPanel.TabIndex = 31;
            this.LoginPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(176, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Todavía no tenes cuenta, créala ahora:";
            // 
            // LeyendaSeaMan
            // 
            this.LeyendaSeaMan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LeyendaSeaMan.AutoSize = true;
            this.LeyendaSeaMan.BackColor = System.Drawing.Color.Transparent;
            this.LeyendaSeaMan.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeyendaSeaMan.ForeColor = System.Drawing.Color.White;
            this.LeyendaSeaMan.Location = new System.Drawing.Point(566, 5);
            this.LeyendaSeaMan.Name = "LeyendaSeaMan";
            this.LeyendaSeaMan.Size = new System.Drawing.Size(83, 20);
            this.LeyendaSeaMan.TabIndex = 32;
            this.LeyendaSeaMan.Text = "SeaMan SRL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Leyenda);
            this.panel1.Controls.Add(this.Aceptar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 227);
            this.panel1.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.Clave);
            this.panel3.Location = new System.Drawing.Point(187, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 46);
            this.panel3.TabIndex = 21;
            // 
            // Clave
            // 
            this.Clave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Clave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.ForeColor = System.Drawing.Color.Black;
            this.Clave.Location = new System.Drawing.Point(10, 12);
            this.Clave.MaxLength = 200;
            this.Clave.Name = "Clave";
            this.Clave.PasswordChar = '*';
            this.Clave.Size = new System.Drawing.Size(409, 22);
            this.Clave.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.Usuario);
            this.panel2.Location = new System.Drawing.Point(187, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 46);
            this.panel2.TabIndex = 20;
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.Black;
            this.Usuario.Location = new System.Drawing.Point(10, 12);
            this.Usuario.MaxLength = 200;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(409, 22);
            this.Usuario.TabIndex = 0;
            // 
            // Leyenda
            // 
            this.Leyenda.AutoSize = true;
            this.Leyenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leyenda.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Leyenda.Location = new System.Drawing.Point(419, 16);
            this.Leyenda.Name = "Leyenda";
            this.Leyenda.Size = new System.Drawing.Size(209, 19);
            this.Leyenda.TabIndex = 19;
            this.Leyenda.Text = "Iniciar sesión en Screen AI";
            // 
            // Aceptar
            // 
            this.Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.Color.Black;
            this.Aceptar.Location = new System.Drawing.Point(475, 179);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(147, 33);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Login";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(189, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLAVE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // Alta
            // 
            this.Alta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alta.ForeColor = System.Drawing.Color.Black;
            this.Alta.Location = new System.Drawing.Point(406, 261);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(240, 33);
            this.Alta.TabIndex = 3;
            this.Alta.Text = "Crear cuenta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.Alta_Click);
            // 
            // Fondo
            // 
            this.Fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fondo.Image = global::Horus.Properties.Resources.Wallpaper1;
            this.Fondo.Location = new System.Drawing.Point(0, 82);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(1184, 679);
            this.Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fondo.TabIndex = 32;
            this.Fondo.TabStop = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.HeaderPanel.Controls.Add(this.CloudIcon);
            this.HeaderPanel.Controls.Add(this.label5);
            this.HeaderPanel.Controls.Add(this.label6);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1184, 82);
            this.HeaderPanel.TabIndex = 28;
            // 
            // CloudIcon
            // 
            this.CloudIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloudIcon.Image = global::Horus.Properties.Resources.CloudIcon;
            this.CloudIcon.Location = new System.Drawing.Point(1094, 4);
            this.CloudIcon.Name = "CloudIcon";
            this.CloudIcon.Size = new System.Drawing.Size(79, 73);
            this.CloudIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloudIcon.TabIndex = 26;
            this.CloudIcon.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1015, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Proyecto Horus";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(914, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 39);
            this.label6.TabIndex = 24;
            this.label6.Text = "Screen AI";
            // 
            // WaitAnimation
            // 
            this.WaitAnimation.Image = global::Horus.Properties.Resources.Loading;
            this.WaitAnimation.Location = new System.Drawing.Point(551, 299);
            this.WaitAnimation.Name = "WaitAnimation";
            this.WaitAnimation.Size = new System.Drawing.Size(160, 160);
            this.WaitAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WaitAnimation.TabIndex = 30;
            this.WaitAnimation.TabStop = false;
            this.WaitAnimation.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Streams
            // 
            this.Streams.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Streams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Streams.Location = new System.Drawing.Point(0, 0);
            this.Streams.Margin = new System.Windows.Forms.Padding(0);
            this.Streams.Name = "Streams";
            this.Streams.Padding = new System.Drawing.Point(0, 0);
            this.Streams.SelectedIndex = 0;
            this.Streams.Size = new System.Drawing.Size(1184, 761);
            this.Streams.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Streams.TabIndex = 31;
            // 
            // NewStream
            // 
            this.NewStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewStream.BackColor = System.Drawing.SystemColors.Control;
            this.NewStream.FlatAppearance.BorderSize = 0;
            this.NewStream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStream.Location = new System.Drawing.Point(1071, 0);
            this.NewStream.Margin = new System.Windows.Forms.Padding(0);
            this.NewStream.Name = "NewStream";
            this.NewStream.Size = new System.Drawing.Size(111, 24);
            this.NewStream.TabIndex = 32;
            this.NewStream.Text = "Agregar Stream";
            this.NewStream.UseVisualStyleBackColor = false;
            this.NewStream.Click += new System.EventHandler(this.NewStream_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.WaitAnimation);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NewStream);
            this.Controls.Add(this.Streams);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen AI by Proyecto Horus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Landing_Load);
            this.Resize += new System.EventHandler(this.Landing_Resize);
            this.MainPanel.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloudIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitAnimation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Clave;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Fondo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LeyendaSeaMan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Leyenda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox WaitAnimation;
        private System.Windows.Forms.PictureBox CloudIcon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl Streams;
        private System.Windows.Forms.Button NewStream;
    }
}