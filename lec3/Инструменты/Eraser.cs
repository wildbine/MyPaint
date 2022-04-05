using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyPaint
{
    public class Eraser : Instrument
    {
        private static int _sizeOfLastik = 10;
        public static int SizeOfLastik
        {
            get => _sizeOfLastik;
            set => _sizeOfLastik = value;
        }

        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
                float centerX = ((Point)StartPoint).X;//(currentPoint.X - ((Point)StartPoint).X) / 2;
                float centerY = ((Point)StartPoint).Y; //(currentPoint.Y - ((Point)StartPoint).Y) / 2;
                float radius = (float)(Math.Sqrt(Math.Pow((currentPoint.X - ((Point)StartPoint).X), 2) +
                    Math.Pow((currentPoint.Y - ((Point)StartPoint).Y), 2)));
                Graphics.FromImage(CurrentImage).FillEllipse(new SolidBrush(BackGround), centerX - radius, centerY - radius,
                         radius + radius + SizeOfLastik, radius + radius + SizeOfLastik);
                // Graphics.FromImage(CurrentImage).FillEllipse(new SolidBrush(BackGround), 
                //    GetRectangle(Point.Subtract((Point)StartPoint, (Size)Diag),
                //   Point.Add(currentPoint, (Size)Diag)));
                g.DrawImage(CurrentImage, 0, 0);
                StartPoint = currentPoint;
            }
        }
    }
}
