namespace Horus {
    partial class MiniVisor {
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
            this.PreviewWindow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewWindow
            // 
            this.PreviewWindow.BackColor = System.Drawing.Color.Black;
            this.PreviewWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewWindow.Location = new System.Drawing.Point(0, 0);
            this.PreviewWindow.Name = "PreviewWindow";
            this.PreviewWindow.Size = new System.Drawing.Size(380, 272);
            this.PreviewWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviewWindow.TabIndex = 4;
            this.PreviewWindow.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MiniVisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 272);
            this.Controls.Add(this.PreviewWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "MiniVisor";
            this.Text = "Mini Visor";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiniVisor_Closing);
            this.Load += new System.EventHandler(this.MiniVisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PreviewWindow;
        private System.Windows.Forms.Timer timer1;
    }
}