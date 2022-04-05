using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public class PenDrawer : Instrument
    {
        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
                Graphics.FromImage(CurrentImage).DrawLine(Pen, (Point)StartPoint, currentPoint);
                g.DrawImage(CurrentImage, 0, 0);
                StartPoint = currentPoint;
            }
        }
    }
}
