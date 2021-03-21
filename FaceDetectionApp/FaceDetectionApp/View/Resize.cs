using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace FaceDetectionApp.View
{
    public partial class Resize : Form
    {
        public Resize()
        {
            InitializeComponent();
        }
        private Bitmap OriginalBitmap;
        private void btnText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFile = new OpenFileDialog();
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                OriginalBitmap = new Bitmap(ofdFile.FileName);
                picText.BackgroundImage = OriginalBitmap;
                picText.Visible = true;
            }
        }
    }
}
