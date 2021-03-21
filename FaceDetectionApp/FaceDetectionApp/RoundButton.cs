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
    class RoundButton:Button
    {
        int rad = 30;
        int sizeborder = 1;
        bool isHovering;
        Color _borderColor = Color.Green;
        Color _onHoverBorderColor=Color.Gray;
        //Color _buttonColor;
        Color _onHoverButtonColor=Color.Red;
        //Color _textColor;
        Color _onHoverTextColor=Color.Blue;

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

        public RoundButton()
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

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);            
            Brush brush = new SolidBrush(isHovering ? _onHoverButtonColor : this.BackColor);                                   

            GraphicsPath GraphPath = GetRoundPath(Rect, rad);
            e.Graphics.FillPath(brush, GraphPath);

            brush.Dispose();
            brush = new SolidBrush(isHovering ? _onHoverBorderColor : _borderColor);
            using (Pen pen = new Pen(brush, sizeborder))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }

            this.Region = new Region(GraphPath);
            //Text

            brush.Dispose();
            brush = new SolidBrush(isHovering ? _onHoverTextColor : this.ForeColor);
            SizeF stringSize = e.Graphics.MeasureString(Text, Font);
            e.Graphics.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
        }


    }
}
