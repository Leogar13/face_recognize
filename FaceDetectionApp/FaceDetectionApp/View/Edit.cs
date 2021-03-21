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
using System.IO;
using System.Drawing.Imaging;
using Emgu.CV.Structure;
using Emgu.CV;

namespace FaceDetectionApp.View
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }
        private Bitmap OriginalBitmap;
        private Bitmap RotatedBitmap;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtAngle.Text = trackBar1.Value.ToString();
            float angle = float.Parse(txtAngle.Text);
            RotatedBitmap = RotateBitmap (OriginalBitmap, angle);
            picRotated.BackgroundImage = RotatedBitmap;
            SizeForm();
        }

        private void txtAngle_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Change_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFile = new OpenFileDialog();
            if(ofdFile.ShowDialog() == DialogResult.OK)
            {
                OriginalBitmap = new Bitmap(ofdFile.FileName);
                picRotated.BackgroundImage = OriginalBitmap;
                picRotated.Visible = true;
            }
        }

        private Bitmap RotateBitmap (Bitmap bm, float angle)
        {
            Matrix rotate_at_origi = new Matrix();
            rotate_at_origi.Rotate(angle);

            PointF[] points =
            {
                new PointF(0,0),
                new PointF(bm.Width, 0),
                new PointF(bm.Width, bm.Height),
                new PointF(0,bm.Height),

            };
            rotate_at_origi.TransformPoints(points);
            float xmin, xmax, ymin, ymax;
            GetPointBound(points, out xmin, out xmax, out ymin, out ymax);

            int wid = (int)Math.Round(xmax - xmin);
            int hgt = (int)Math.Round(ymax - ymin);
            Bitmap result = new Bitmap(wid, hgt);

            Matrix rotate_at_center = new Matrix();
            rotate_at_center.RotateAt(angle, new PointF(wid / 2f, hgt / 2f));

            using (Graphics gr = Graphics.FromImage(result))
            {
                gr.InterpolationMode = InterpolationMode.High;

                gr.Clear(bm.GetPixel(0, 0));
                gr.Transform = rotate_at_center;

                int x = (wid - bm.Width) / 2;
                int y = (hgt - bm.Height) / 2;
                gr.DrawImage(bm, x, y);
            }

            return result;
        }

        private void GetPointBound(PointF[] points, out float xmin, out float xmax, out float ymin, out float ymax)
        {
            xmin = points[0].X;
            xmax = xmin;
            ymin = points[0].Y;
            ymax = ymin;
            foreach (PointF point in points)
            {
                if (xmin > point.X) xmin = point.X;
                if (xmax < point.X) xmax = point.X;
                if (ymin > point.Y) ymin = point.Y;
                if (ymax < point.Y) ymax = point.Y;
            }
        }
        private void SizeForm()
        {
            int wid = picRotated.Right + picRotated.Left;
            int hgt = picRotated.Bottom + picRotated.Left;
            this.ClientSize = new Size(
                Math.Max(wid, this.ClientSize.Width),
                Math.Max(hgt, this.ClientSize.Height));
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

                try
                {
                    Image<Bgr, byte> saver = new Image<Bgr, byte>(RotatedBitmap);
                    saver.Save(Application.StartupPath + "\\Data\\Images\\" + txtTen.Text + ".png");
                    MessageBox.Show("Thành công!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ảnh Lưu không thành công!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
        }

       

        private void picRotated_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show(" Do you wat exit ?", "Error", MessageBoxButtons.OKCancel);
                if ( h == DialogResult.Yes)
                {
                Application.Exit();
                }
            this.Close();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
