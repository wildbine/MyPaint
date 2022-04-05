using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public class TriangleDrawer : Instrument
    {
        private bool fill;

        public TriangleDrawer(bool fill = false)
        {
            this.fill = fill;
        }

        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
                g.DrawImage(CurrentImage, 0, 0);
                Point copy = (Point)StartPoint;
                if (Instrument.Shift)
                {
                    Point p2 = new Point(((Point)StartPoint).X, ((Point)StartPoint).Y - (((Point)StartPoint).Y - currentPoint.Y));
                    int storona = (int)Math.Sqrt(((Math.Pow((((Point)StartPoint).X - p2.X), 2)) +  Math.Pow(((((Point)StartPoint).Y) - p2.Y), 2)));
                    if (currentPoint.X <= p2.X) storona = -storona;
                    Point p3 = new Point(p2.X + storona, p2.Y);
                    Point[] point = new Point[] { (Point)StartPoint, p2, p3, copy };
                    g.DrawPolygon(Pen, point);
                    if (fill)
                        g.FillPolygon(Brush, point);
                }
                else
                {
                    Point peresechenie = new Point(currentPoint.X - (currentPoint.X - ((Point)StartPoint).X), currentPoint.Y);
                    Point[] point = new Point[] { (Point)StartPoint, currentPoint, peresechenie, copy };
                    g.DrawLines(Pen, point);
                    if (fill)
                        g.FillPolygon(Brush, point);
                }
            }
        }

    }
}