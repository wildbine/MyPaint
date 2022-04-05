using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyPaint
{
    public class CircleDrawer : Instrument
    {
        private bool fill;
        public CircleDrawer(bool fill = false)
        {
            this.fill = fill;
        }

        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
                g.DrawImage(CurrentImage, 0, 0);
                if (!Shift)
                {
                    if (fill)
                    {
                        g.FillEllipse(Brush, GetRectangle((Point)StartPoint, currentPoint));
                    }
                    g.DrawEllipse(Pen, GetRectangle((Point)StartPoint, currentPoint));
                }
                else
                {

                    float centerX = ((Point)StartPoint).X;//(currentPoint.X - ((Point)StartPoint).X) / 2;
                    float centerY = ((Point)StartPoint).Y; //(currentPoint.Y - ((Point)StartPoint).Y) / 2;
                    float radius = (float)(Math.Sqrt(Math.Pow((currentPoint.X - ((Point)StartPoint).X), 2) +
                        Math.Pow((currentPoint.Y - ((Point)StartPoint).Y), 2)));
                    if (fill)
                    {
                        g.FillEllipse(Brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
                    }
                    g.DrawEllipse(Pen, centerX - radius, centerY - radius,
                         radius + radius, radius + radius);
                
                }
            }
        }
    }
}
