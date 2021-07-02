namespace Horus {
    partial class AreaSelector {
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
            this.Listo = new System.Windows.Forms.Button();
            this.AreaSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Listo
            // 
            this.Listo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Listo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Listo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Listo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listo.ForeColor = System.Drawing.Color.Black;
            this.Listo.Location = new System.Drawing.Point(499, 430);
            this.Listo.Name = "Listo";
            this.Listo.Size = new System.Drawing.Size(129, 38);
            this.Listo.TabIndex = 1;
            this.Listo.Text = "Listo";
            this.Listo.UseVisualStyleBackColor = true;
            // 
            // AreaSize
            // 
            this.AreaSize.FormattingEnabled = true;
            this.AreaSize.Items.AddRange(new object[] {
            "640x480",
            "800x600",
            "720x1290",
            "1080x1920"});
            this.AreaSize.Location = new System.Drawing.Point(12, 12);
            this.AreaSize.Name = "AreaSize";
            this.AreaSize.Size = new System.Drawing.Size(109, 21);
            this.AreaSize.TabIndex = 2;
            this.AreaSize.Text = "640x480";
            this.AreaSize.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // AreaSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.AreaSize);
            this.Controls.Add(this.Listo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "AreaSelector";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AreaSelector_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AreaSelector_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Listo;
        private System.Windows.Forms.ComboBox AreaSize;
    }
}