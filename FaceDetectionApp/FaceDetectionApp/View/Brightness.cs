using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
namespace FaceDetectionApp.View

{
    public partial class Brightness : Form
    {
        public Brightness()
        {
            InitializeComponent();
        }
        private Image Img;
        private Bitmap OriginalBitmap;
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFile = new OpenFileDialog();
            if( ofdFile.ShowDialog() == DialogResult.OK)
            {
                OriginalBitmap = new Bitmap(ofdFile.FileName);
                picBright.BackgroundImage = OriginalBitmap;
                picBright.Visible = true;
                Img = Image.FromFile(ofdFile.FileName);
                LoadImage();
            }
        }

        private void LoadImage()
        {
            int imgWidth = Img.Width;
            int imgHeight = Img.Height;
            picBright.Width = imgWidth;
            picBright.Height = imgHeight;
            picBright.Image = Img;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DomainUpDownBright.Text = trackBar1.Value.ToString();

            float value = trackBar1.Value * 0.01f;
            float[][] colorMatrixElement =
            {
                new float[]
                {
                    1,
                    0,
                    0,
                    0,
                    0
                },
                new float[]
                {
                    0,
                    1,
                    0,
                    0,
                    0
                },
                new float[]
                {
                    0,
                    0,
                    1,
                    0,
                    0
                },
                new float[]
                {
                    0,
                    0,
                    0,
                    1,
                    0
                },
                new float[]
                {
                    value,
                    value,
                    value,
                    0,
                    1
                }
            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElement);
            ImageAttributes imageAttributes = new ImageAttributes();

            imageAttributes.SetColorMatrix(colorMatrix,ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            

            Image _img = Img;
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle
                (0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            picBright.Image = bm_dest;
        }

        private void btndomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Brightness_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show(" Do you wat exit ?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
            this.Close();
        }
    }
}
