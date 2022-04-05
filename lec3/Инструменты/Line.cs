using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;
using System.Windows;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyPaint
{
    public class Line : Instrument
    {
        private bool fill;
        public Line(bool fill = false)
        {
            this.fill = fill;
        }
        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
                Pen pen = new Pen(Pen.Color, Pen.Width);
                pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                g.DrawImage(CurrentImage, 0, 0);
                if (Instrument.Shift)
                {
                    Point p = new Point(); p = (Point)StartPoint;
                    double degrees;
                    int min = Math.Min(Math.Abs(currentPoint.X - p.X), Math.Abs(currentPoint.Y - p.Y));
                    degrees = ((Math.Atan2(currentPoint.Y - ((Point)StartPoint).Y, currentPoint.X - ((Point)StartPoint).X) + 2 * Math.PI) * 180 / Math.PI) % 360;
                    if (degrees >= 337.5 || degrees < 22.5)
                    { (currentPoint.X, currentPoint.Y) = (currentPoint.X, p.Y); }

                    else if (degrees >= 22.5 && degrees < 67.5)
                    { (currentPoint.X, currentPoint.Y) = (min+p.X, min+p.Y); }

                    else if (degrees >= 67.5 && degrees < 112.5)
                    { (currentPoint.X, currentPoint.Y) = (p.X, currentPoint.Y); }

                    else if (degrees >= 112.5 && degrees < 157.5)
                    { (currentPoint.X, currentPoint.Y) = (-min+p.X, min+p.Y); }

                    else if (degrees >= 157.5 && degrees < 202.5)
                    { (currentPoint.X, currentPoint.Y) = (currentPoint.X, p.Y); }

                    else if (degrees >= 202.5 && degrees < 247.5)
                    { (currentPoint.X, currentPoint.Y) = (-min+p.X, -min+p.Y); }

                    else if (degrees >= 247.5 && degrees < 292.5)
                    { (currentPoint.X, currentPoint.Y) = (p.X, currentPoint.Y); }

                    else if (degrees >= 292.5 && degrees < 337.5)
                    { (currentPoint.X, currentPoint.Y) = (min+p.X, -min+p.Y); }

                    if (fill)
                        g.DrawLine(pen, (Point)StartPoint, currentPoint);
                    else g.DrawLine(Pen, (Point)StartPoint, currentPoint);

                }
                /*
                    if (!fill)
                    {
                        if (Math.Abs((currentPoint.X) - ((Point)StartPoint).X) == Math.Abs((currentPoint.Y) - (((Point)StartPoint).Y)))
                            g.DrawLine(Pen, (Point)StartPoint, currentPoint);
                        else if (Math.Abs((currentPoint.X - ((Point)StartPoint).X)) == 0 || Math.Abs((currentPoint.X - ((Point)StartPoint).X)) == 0)
                            g.DrawLine(Pen, (Point)StartPoint, currentPoint);
                    }
                    else
                    {
                        if (Math.Abs((currentPoint.X) - ((Point)StartPoint).X) == Math.Abs((currentPoint.Y) - (((Point)StartPoint).Y)))
                            g.DrawLine(pen, (Point)StartPoint, currentPoint);
                        else if (Math.Abs((currentPoint.X - ((Point)StartPoint).X)) == 0 || Math.Abs((currentPoint.X - ((Point)StartPoint).X)) == 0)
                            g.DrawLine(pen, (Point)StartPoint, currentPoint);
                    } */
            
                else
                {
                    if (fill)
                        g.DrawLine(pen, (Point)StartPoint, currentPoint);
                    else g.DrawLine(Pen, (Point)StartPoint, currentPoint);
                }

            }
        }
     
    }
}
