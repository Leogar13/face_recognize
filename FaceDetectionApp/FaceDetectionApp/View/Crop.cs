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
using Emgu.CV;
using Emgu.CV.Structure;

namespace FaceDetectionApp.View
{
    public partial class Crop : Form
    {
        public Crop()
        {
            InitializeComponent();
        }
 
 
        private Bitmap OriginalBitmap;
       private Bitmap CropBitmap;

        int cropX;
        int cropY;
        int cropWidth;
        int cropHeight;
        public Pen cropPen;

        int ocropX;
        int ocropY;

        public DashStyle cropDashStyle = DashStyle.DashDot;
        public float cropPenSize ;
        public Color cropPenColor = Color.Black;
        //public bool CreateText = false;


        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFile = new OpenFileDialog();
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                OriginalBitmap = new Bitmap(ofdFile.FileName);
                picCrop1.BackgroundImage = OriginalBitmap;
                picCrop1.Visible = true;
            }
        }



        private void picCrop_MouseDown(object sender, MouseEventArgs e )
        {
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    cropX = e.X;
                    cropY = e.Y;
                    cropPen = new Pen(cropPenColor, cropPenSize);
                    cropPen.DashStyle = DashStyle.DashDotDot;
                    Cursor = Cursors.Cross;
                    picCrop1.Refresh();

                }
            }
            catch (Exception ex)
            { }
        }

        private void picCrop_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Cursor = Cursors.Default;
                try
                {
                    if (cropWidth < 1) { }
                    Rectangle rect = new Rectangle(cropX, cropY,cropWidth, cropHeight);
                    Bitmap bit = new Bitmap(picCrop1.Image, picCrop1.Width, picCrop1.Height);

                    CropBitmap = new Bitmap(cropWidth, cropHeight);
                    Graphics g = Graphics.FromImage(CropBitmap);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel);
                    picCrop2.Image = CropBitmap;
                 }

                catch( Exception ex) { }
            }
            
            catch ( Exception )
            { }
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Bgr, byte> saver = new Image<Bgr, byte>(CropBitmap);
                saver.Save(Application.StartupPath + "\\Data\\Image\\ " + txtSave.Text + ".png");
                MessageBox.Show(" Lưu thành công!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception)
            {
                MessageBox.Show(" Ảnh lưu không thành công !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
