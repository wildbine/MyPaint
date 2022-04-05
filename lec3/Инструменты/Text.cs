using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public class Text : Instrument
    {

        private bool fill;

        public Text(bool fill = false)
        {
            this.fill = fill;
        }

        private static Size _textSize = new Size(100, 100);

        public static Size TextSize
        {
            get => _textSize;
            set => _textSize = value;
        }
        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
            }
        }
    }
}
