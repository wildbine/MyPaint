using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public class Painter
    {
        public enum InstrumentType
        {
            Eraser,
            PenDrawer,
            RectDrawer,
            RectFiller,
            CircleDrawer,
            CircleFiller,
            Line,
            LineFiller,
            PipetkaDrawer,
            PipetkaFiller,
            Text,
            TextCleaner,
            TriangleDrawer,
            TriangleFiller,
        }
        //private int figureCount = 5;
        private Image? _img;
        private readonly List<Instrument> _ins = new List<Instrument>();

       // public string Text;
        public string State = "free";
        public InstrumentType InsType
        {
            get;
            set;
        }
       
        private Size _containerSize;
        public Size ContainerSize
        {
            get => _containerSize;
            set
            {
                _containerSize = value;
                var img = new Bitmap(1920, 885, PixelFormat.Format24bppRgb);
                Graphics.FromImage(img).Clear(Instrument.BackGround);
                var ig = Graphics.FromImage(img);
                if (Instrument.CurrentImage is not null)
                    ig.DrawImage(Instrument.CurrentImage, 0, 0);
                Instrument.CurrentImage = img;
            }
        }
        public Painter(Size containerSize)
        {
            ContainerSize = containerSize;
            _ins.Add(new Eraser());
            _ins.Add(new PenDrawer());
            _ins.Add(new RectDrawer());
            _ins.Add(new RectDrawer(true));
            _ins.Add(new CircleDrawer());
            _ins.Add(new CircleDrawer(true));
            _ins.Add(new Line());
            _ins.Add(new Line(true));
            _ins.Add(new Pipetka()); 
            _ins.Add(new Pipetka(true));
            _ins.Add(new Text());
            _ins.Add(new Text(true));
            _ins.Add(new TriangleDrawer());
            _ins.Add(new TriangleDrawer(true));
        }

        public void Paint(Graphics g)
        {
            if (Instrument.CurrentImage is not null)
            {
                g.DrawImage(Instrument.CurrentImage, 0, 0);
            }
        }

        public void Clear(Graphics g)
        {
            if (Instrument.CurrentImage is not null)
            {
                g.Clear(Instrument.BackGround);
            }
        }

        public void StartDrawing(Point location)
        {
            if (Instrument.CurrentImage is not null)
            {
                _ins[(int)InsType].Start(location, (Image)Instrument.CurrentImage);
            }
        }

        public void StopDrawing(Point location)
        {
            if (Instrument.CurrentImage is not null)
            {
                var ig = Graphics.FromImage(Instrument.CurrentImage);
                _ins[(int)InsType].Draw(ig, location);
            }
            _ins[(int)InsType].Stop();
            Instrument.Shift = false;
        }

        public void Draw(Point location, Graphics tempG)
        {
            var bg =
                BufferedGraphicsManager.Current.Allocate(
                    tempG,
                    Rectangle.Ceiling(tempG.VisibleClipBounds)
                );
            if (Instrument.CurrentImage is not null)
                bg.Graphics.DrawImage(Instrument.CurrentImage, 0, 0);
            else bg.Graphics.Clear(Instrument.BackGround);
            _ins[(int)InsType].Draw(bg.Graphics, location);
            bg.Render(tempG);
            bg.Dispose();
        }

        public void PaintText(Painter p, Panel panel, Graphics g)
        {
            for (int i = 0; i < panel.Controls.Count - 1; ++i) 
            {
                string drawString = Instrument.Text[i];
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", Instrument.Pen.Width);
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                g.DrawString(drawString, drawFont, Instrument.Brush, Instrument.TextLocation[i]);
                drawFont.Dispose();
            }
            Paint(Graphics.FromImage(Instrument.CurrentImage));
        }
    }
}
