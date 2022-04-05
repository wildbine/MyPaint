using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public class Pipetka : Instrument
    {
        private bool fill;

        public Pipetka(bool fill = false)
        {
            this.fill = fill;
        }
        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
                g.DrawImage(CurrentImage, 0, 0);
                Bitmap bitmap = new Bitmap(CurrentImage);
                PipetkaColor = bitmap.GetPixel(currentPoint.X, currentPoint.Y);
                var b = new SolidBrush(PipetkaColor);
                if (!fill) Instrument.Pen.Color = PipetkaColor; else Instrument.Brush = b;
            }
        }
    }
}
