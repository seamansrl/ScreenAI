using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Inmediata
{
	public class ctlMain : System.Windows.Forms.UserControl {
        public TextBox Inmediata;
        private Timer timer1;
        private PictureBox Frame;
        private IContainer components;

        public ctlMain()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.Inmediata = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Frame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Frame)).BeginInit();
            this.SuspendLayout();
            // 
            // Inmediata
            // 
            this.Inmediata.BackColor = System.Drawing.Color.White;
            this.Inmediata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inmediata.Dock = System.Windows.Forms.DockStyle.Top;
            this.Inmediata.ForeColor = System.Drawing.Color.Black;
            this.Inmediata.Location = new System.Drawing.Point(0, 0);
            this.Inmediata.Multiline = true;
            this.Inmediata.Name = "Inmediata";
            this.Inmediata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Inmediata.Size = new System.Drawing.Size(488, 193);
            this.Inmediata.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frame
            // 
            this.Frame.BackColor = System.Drawing.Color.Black;
            this.Frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Frame.Location = new System.Drawing.Point(0, 193);
            this.Frame.Name = "Frame";
            this.Frame.Size = new System.Drawing.Size(488, 183);
            this.Frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Frame.TabIndex = 1;
            this.Frame.TabStop = false;
            // 
            // ctlMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Frame);
            this.Controls.Add(this.Inmediata);
            this.Name = "ctlMain";
            this.Size = new System.Drawing.Size(488, 376);
            this.Load += new System.EventHandler(this.ctlMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void ctlMain_Load(object sender, System.EventArgs e)
		{
		
		}

        private void timer1_Tick(object sender, EventArgs e) {
            this.Inmediata.Text = Plugin.GlobalValue;

            if (Plugin.ImageStream != null)
                this.Frame.Image = Image.FromStream(Plugin.ImageStream);
        }
    }
}
