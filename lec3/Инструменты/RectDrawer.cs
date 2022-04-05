using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public class RectDrawer : Instrument
    {
        private bool fill;

        public RectDrawer(bool fill = false)
        {
            this.fill = fill;
        }

        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
                g.DrawImage(CurrentImage, 0, 0);
                if (!Instrument.Shift)
                {
                    if (fill)
                    {
                        g.FillRectangle(Brush, GetRectangle((Point)StartPoint, currentPoint));
                    }
                    g.DrawRectangle(Pen, GetRectangle((Point)StartPoint, currentPoint));
                }
                else
                {
                    /* int p = Math.Min(((Point)StartPoint).X - currentPoint.X, ((Point)StartPoint).Y - currentPoint.Y);
                     Point curr = new(p, p);
                     Point p2 = new(p, ((Point)StartPoint).Y);
                     Point p4 = new(((Point)StartPoint).X, p);
                     Point copy = (Point)StartPoint;
                     Point[] point = new Point[] {(Point)StartPoint, p2, curr, p4, copy};
                     if (fill)
                     {
                         g.FillPolygon(Brush, point);
                     }
                     g.DrawPolygon(Pen, point); */

                    int storona = Math.Abs(Math.Max(currentPoint.X - ((Point)StartPoint).X, (currentPoint.Y - ((Point)StartPoint).Y)));
                        Point p = new Point();
                        int storonax, storonay; storonax = storonay = storona;
                    if (currentPoint.X < ((Point)StartPoint).X && currentPoint.Y < ((Point)StartPoint).Y) { storonay = -storonay; storonax = -storonax; }
                    else if (currentPoint.X < ((Point)StartPoint).X && currentPoint.Y > ((Point)StartPoint).Y) storonax = -storonax;
                    else if (currentPoint.X > ((Point)StartPoint).X && currentPoint.Y < ((Point)StartPoint).Y) storonay = -storonay;
                    p.X = ((Point)StartPoint).X + storonax; p.Y = ((Point)StartPoint).Y + storonay;
                        if (fill)  g.FillRectangle(Brush, GetRectangle((Point)StartPoint, p));
                        g.DrawRectangle(Pen, GetRectangle((Point)StartPoint, p));
                    
                }
            }
        }
    }
}

