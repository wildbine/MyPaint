using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public abstract class Instrument
    {
        private static Pen           _pen          = new Pen(Color.Black, 1);
        private static Brush         _brush        = new SolidBrush(Color.Black);
        private static Color         _backGround   = Color.White;
        private static Color         _pipetkaColor = Color.White;
        private static List<string>? _text         = new List<string>();
        private static bool          _shift        = false;
        private static List<Point>?  _textLocation = new List<Point>();
        public static List<string>? Text
        {
            get => _text;
            set => _text = value; 
        }

        public static List<Point>? TextLocation { get => _textLocation; set => _textLocation = value; }

        public static bool Shift
        {
            get => _shift;
            set => _shift = value;
        }
        public static Color PipetkaColor
        {
            get => _pipetkaColor;
            set => _pipetkaColor = value;
        }

        protected Point? StartPoint { get; set; }
        public static Pen Pen
        {
            get => _pen;
            set => _pen = value;
        }

        public static Brush Brush
        {
            get => _brush;
            set => _brush = value;
        }

        public static Color BackGround
        {
            get => _backGround;
            set => _backGround = value;
        }

        public static Image? CurrentImage;

        public void Start(Point location, Image currentImage)
        {
            CurrentImage = currentImage;
            StartPoint = location;
        }

        public void Stop()
        {
            StartPoint = null;
        }
        public abstract void Draw(Graphics g, Point currentPoint);
        protected Rectangle GetRectangle(Point p1, Point p2)
        {
            var xMin = Math.Min(p1.X, p2.X);
            var xMax = Math.Max(p1.X, p2.X);
            var yMin = Math.Min(p1.Y, p2.Y);
            var yMax = Math.Max(p1.Y, p2.Y);
            return new Rectangle(xMin, yMin, xMax - xMin, yMax - yMin);
        }
    }
}
