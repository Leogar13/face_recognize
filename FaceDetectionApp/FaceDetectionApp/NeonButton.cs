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
    class NeonButton:Button
    {
        int rad = 30;
        int sizeborder = 1;
        bool isHovering;
        float per=0;

        Color _borderColor = Color.Green;
        Color _onHoverBorderColor = Color.Gray;
        //Color _buttonColor;
        Color _onHoverButtonColor = Color.Red;
        //Color _textColor;
        Color _onHoverTextColor = Color.Blue;
        Color _gradientCenter = Color.LightGreen;
        Color _gradientRound = Color.Black;

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public Color OnHoverButtonColor
        {
            get => _onHoverButtonColor;
            set
            {
                _onHoverButtonColor = value;
                Invalidate();
            }
        }

        //public Color TextColor
        //{
        //    get => _textColor;
        //    set
        //    {
        //        _textColor = value;
        //        Invalidate();
        //    }
        //}

        public Color OnHoverTextColor
        {
            get => _onHoverTextColor;
            set
            {
                _onHoverTextColor = value;
                Invalidate();
            }
        }

        public float PercentileCenterColor
        {
            get { return per; }
            set { per = value; }
        }

        public NeonButton()
        {
            DoubleBuffered = true;
            
            MouseEnter += (sender, e) =>
            {
                isHovering = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                isHovering = false;
                Invalidate();
            };
        }

        public Color GradientRound
        {
            get { return _gradientRound; }
            set { _gradientRound = value; }
        }

        public Color GradientCenter
        {
            get { return _gradientCenter; }
            set { _gradientCenter= value; }
        }

        public int Bordersizing
        {
            get { return sizeborder; }
            set { sizeborder = value; }
        }

        public int BorderRadius
        {
            get { return rad; }
            set { rad = value; }
        }

        public Color OnHoverBorderColor
        {
            get => _onHoverBorderColor;
            set
            {
                _onHoverBorderColor = value;
                Invalidate();
            }
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius, float wid)
        {
            float r2 = radius / 2f;
            //this.ForeColor = System.Drawing.Color.Transparent;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X + wid / 2, Rect.Y + wid / 2, radius - wid, radius - wid, 180, 90);            
            GraphPath.AddArc(Rect.X + Rect.Width - radius + wid / 2, Rect.Y + wid / 2, radius - wid, radius - wid, 270, 90);            
            GraphPath.AddArc(Rect.X + Rect.Width - radius + wid / 2,
                             Rect.Y + Rect.Height - radius + wid / 2, radius - wid, radius - wid, 0, 90);
            GraphPath.AddArc(Rect.X + wid / 2, Rect.Y + Rect.Height - radius + wid / 2, radius - wid, radius - wid, 90, 90);
            
            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            Brush brush = new SolidBrush(isHovering ? _onHoverButtonColor : this.BackColor);
            GraphicsPath NeonPath = GetRoundPath(Rect, rad, per);
               
            using (var gradientbrush = new PathGradientBrush(NeonPath))
            {
                gradientbrush.CenterPoint = new PointF(Rect.Width / 2f, Rect.Height / 2f);
                gradientbrush.CenterColor = _gradientCenter;
                gradientbrush.SurroundColors = new[] { _gradientRound };
                gradientbrush.FocusScales = new PointF(0, 0);
                e.Graphics.FillPath(gradientbrush, NeonPath);
            }                     

            GraphicsPath GraphPath = GetRoundPath(Rect, rad, 10);
            e.Graphics.FillPath(brush, GraphPath);

            brush.Dispose();
            brush = new SolidBrush(isHovering ? _onHoverBorderColor : _borderColor);
            using (Pen pen = new Pen(brush, sizeborder))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }

            this.Region = new Region(NeonPath);

            //Text
            brush.Dispose();
            brush = new SolidBrush(isHovering ? _onHoverTextColor : this.ForeColor);
            SizeF stringSize = e.Graphics.MeasureString(Text, Font);
            e.Graphics.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
        }
    }
}
