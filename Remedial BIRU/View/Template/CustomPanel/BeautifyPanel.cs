using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Remedial_BIRU.Template.CustomPanel
{
    class BeautifyPanel : Panel
    {
        private int borderRadius = 30;
        private int borderWidth = 3;
        private Color borderColor;

        public BeautifyPanel()
        {
            Size = new Size(100, 100);
        }

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }

        public int BorderWidth
        {
            get => borderWidth;
            set { borderWidth = value; this.Invalidate(); }
        }

        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }

        private GraphicsPath GetPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();

            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);

            graphicsPath.CloseFigure();

            return graphicsPath;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);

            if (borderRadius < 2)
            {
                Region = new Region(rectangleF);
                return;
            }

            GraphicsPath graphicsPath = GetPath(rectangleF, borderRadius);
            Pen pen = new Pen(borderColor, borderWidth);
            Region = new Region(graphicsPath);
            e.Graphics.DrawPath(pen, graphicsPath);
        }
    }
}
