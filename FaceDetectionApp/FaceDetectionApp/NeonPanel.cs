using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDetectionApp
{
    class NeonPanel : Panel
    {
        int rad = 100;
        Color ct = Color.Red;
        Color roundc = Color.Black;
        int per=0;

        public int BorderRadius
        {
            get { return rad; }
            set { rad = value; }
        }

        public int PercentileCenterColor
        {
            get { return per; }
            set { per = value; }
        }

        public Color CenterColor
        {
            get { return ct; }
            set { ct = value; }
        }

        public Color RoundColor
        {
            get { return roundc; }
            set { roundc = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {            
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, rad,per);
            using (var RPath = GetRoundPath(Rect,rad,per))
            {
                //RPath.AddRectangle(Rect);
                using (var brush = new PathGradientBrush(RPath))
                {
                    brush.CenterPoint = new PointF(Rect.Width / 2f, Rect.Height / 2f);
                    brush.CenterColor = ct;
                    brush.SurroundColors = new[] { roundc };
                    brush.FocusScales = new PointF(0, 0);
                    e.Graphics.FillPath(brush, RPath);                    
                }
            }
            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(this.BackColor, 1.75f))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }
            base.OnPaint(e);
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius, float wid)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            //GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            //GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            //GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            //GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            //GraphPath.AddArc(Rect.X + Rect.Width - radius,
            //                 Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            //GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            //GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            //GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

            GraphPath.AddArc(Rect.X + wid / 2, Rect.Y + wid / 2, radius - wid, radius - wid, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - radius + wid / 2, Rect.Y + wid / 2, radius - wid, radius - wid, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - radius + wid / 2,
                             Rect.Y + Rect.Height - radius + wid / 2, radius - wid, radius - wid, 0, 90);
            GraphPath.AddArc(Rect.X + wid / 2, Rect.Y + Rect.Height - radius + wid / 2, radius - wid, radius - wid, 90, 90);


            GraphPath.CloseFigure();
            return GraphPath;
        }
    }
}
