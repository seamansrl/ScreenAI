using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horus {
    public partial class MiniVisor : Form {

        Int32 Sized = 0;

        public MiniVisor() {
            InitializeComponent();
        }

        private void MiniVisor_Load(object sender, EventArgs e) {
            Program.MiniVisor_visible = true;
        }

        private void MiniVisor_Closing(object sender, FormClosingEventArgs e) {
            Program.MiniVisor_visible = false;
        }

        private Bitmap CombineBitmap(Image[] Images) {
            List<Bitmap> images = new List<Bitmap>();
            Bitmap finalImage = null;

            try {
                Int32 width = 0;
                Int32 height = 0;

                foreach (Image image in Images) {
                    if (image != null) {
                        Bitmap bitmap = new Bitmap(image);

                        width += bitmap.Width;
                        height = bitmap.Height > height ? bitmap.Height : height;

                        images.Add(bitmap);
                    }
                }

                if (images.Count > 0) {
                    finalImage = new Bitmap(width, height);

                    using (Graphics g = Graphics.FromImage(finalImage)) {
                        g.Clear(Color.Black);

                        Int32 offset = 0;

                        foreach (Bitmap image in images) {
                            if (image != null) {
                                g.DrawImage(image, new Rectangle(offset, 0, image.Width, image.Height));
                                offset += image.Width;
                            }
                        }
                    }

                    return finalImage;
                }
                else {
                    return null;
                }
            }
            catch (Exception ex) {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally {
                foreach (Bitmap image in images) {
                    image.Dispose();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            try {
                Bitmap ImagenToShow = CombineBitmap(Program.PreviewMatrix);
                
                if (ImagenToShow != null) {
                    if (Sized != ImagenToShow.Width) {
                        Int32 ToDivide = 1;

                        for (Int32 Ciclos = 0; Ciclos <= 10; Ciclos++)
                            if ((ImagenToShow.Width / ToDivide) > Screen.PrimaryScreen.WorkingArea.Width)
                                ToDivide++;

                        this.Width = Convert.ToInt32(Math.Truncate(Convert.ToDecimal(ImagenToShow.Width / ToDivide)));
                        this.Height = Convert.ToInt32(Math.Truncate(Convert.ToDecimal(ImagenToShow.Height / ToDivide)));

                        this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 30;
                        this.Left = Convert.ToInt32(Math.Truncate(Convert.ToDecimal(Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2));

                        Sized = ImagenToShow.Width;
                    }

                    this.PreviewWindow.Image = ImagenToShow;
                }
            }
            catch { }
        }
    }
}
