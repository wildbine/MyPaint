using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Painter painter = new Painter(panel1.Size);
            p = painter;
            p.InsType = Painter.InstrumentType.PenDrawer;
            Instrument.Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Instrument.Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.MouseWheel += Form1_MouseWheel;
            KeyPreview = true;
        }

     

        private void Form1_MouseWheel(object? sender, MouseEventArgs e)
        {
            Eraser.SizeOfLastik += (int)e.Delta/100;
        }

        private Painter p;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            p.Paint(e.Graphics);
        }

      
      
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            /*p.InsType = e.Button == MouseButtons.Left
                ? Painter.InstrumentType.Line
                : Painter.InstrumentType.RectFiller;*/
            /*if (e.Button == MouseButtons.Right && p.InsType == Painter.InstrumentType.RectDrawer)
                p.InsType = Painter.InstrumentType.RectFiller;
            else if (e.Button == MouseButtons.Right && p.InsType == Painter.InstrumentType.CircleDrawer)
                p.InsType = Painter.InstrumentType.CircleFiller;
            else if (e.Button == MouseButtons.Left)*/
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift) Instrument.Shift = true;
                switch (e.Button)
            {
                case MouseButtons.Right:
                    if (p.InsType == Painter.InstrumentType.CircleDrawer) p.InsType = Painter.InstrumentType.CircleFiller;
                    else if (p.InsType == Painter.InstrumentType.RectDrawer) p.InsType = Painter.InstrumentType.RectFiller;
                    else if (p.InsType == Painter.InstrumentType.PipetkaDrawer) p.InsType = Painter.InstrumentType.PipetkaFiller;
                    else if (p.InsType == Painter.InstrumentType.Line) p.InsType = Painter.InstrumentType.LineFiller;
                    else if (p.InsType == Painter.InstrumentType.TriangleDrawer) p.InsType = Painter.InstrumentType.TriangleFiller; break;
                case MouseButtons.Left:
                    if (p.InsType == Painter.InstrumentType.CircleFiller) p.InsType = Painter.InstrumentType.CircleDrawer;
                    else if (p.InsType == Painter.InstrumentType.RectFiller) p.InsType = Painter.InstrumentType.RectDrawer;
                    else if (p.InsType == Painter.InstrumentType.PipetkaFiller) p.InsType = Painter.InstrumentType.PipetkaDrawer; 
                    else if (p.InsType == Painter.InstrumentType.LineFiller) p.InsType = Painter.InstrumentType.Line; 
                    else if (p.InsType == Painter.InstrumentType.TriangleFiller) p.InsType = Painter.InstrumentType.TriangleDrawer; break;
            }
  
            if ((p.InsType == Painter.InstrumentType.Text))            
            { 

                var tb = new TextBox() { Name = "textbox", Location = e.Location};
                Instrument.Text.Add(tb.Text);
                Instrument.TextLocation.Add(e.Location);
                panel1.Controls.Add(tb);
            }
            p.StartDrawing(e.Location);
        }
        
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            p.StopDrawing(e.Location);
            panel1.Update();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            p.Draw(e.Location, panel1.CreateGraphics());
        }

        private void white_color_Click(object sender, EventArgs e)
        {
             Instrument.Pen.Color = ((Button)sender).BackColor;
        }


        private void color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Instrument.Pen.Color = colorDialog1.Color;
            ((Button)sender).BackColor = colorDialog1.Color;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.BackColor = Instrument.BackGround;
            p.ContainerSize = panel1.Size;
            panel1.Refresh();
        }
        private void clear_Click(object sender, EventArgs e)
        {
               // p.Draw(new Point(panel1.Width, panel1.Height), panel1.CreateGraphics());
            if (Instrument.CurrentImage is not null)
            Graphics.FromImage(Instrument.CurrentImage).Clear(Instrument.BackGround);
            panel1.Controls.Clear();
            panel1.Refresh();
        }

        private void background_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
               Instrument.BackGround = colorDialog1.Color;
            ((Button)sender).BackColor = colorDialog1.Color;
            var img = new Bitmap(1920, 885, PixelFormat.Format24bppRgb);
            Graphics.FromImage(img).Clear(Instrument.BackGround);
            var ig = Graphics.FromImage(img);
            if (Instrument.CurrentImage is not null)
                ig.DrawImage(Instrument.CurrentImage, 0, 0);
            Instrument.CurrentImage = img;
            panel1.Refresh();
        }

        private void prncil_Click(object sender, EventArgs e)
        {
            p.InsType = Painter.InstrumentType.PenDrawer;
        }

        private void straight_Click(object sender, EventArgs e)
        {
            p.InsType = Painter.InstrumentType.Line;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            p.InsType = Painter.InstrumentType.CircleDrawer;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            p.InsType = Painter.InstrumentType.RectDrawer;
        }

        private void pipetka_Click(object sender, EventArgs e)
        {
            p.InsType = Painter.InstrumentType.PipetkaDrawer;
        }
        private void eraser_Click(object sender, EventArgs e)
        {
            p.InsType = Painter.InstrumentType.Eraser;
        }

        private void fillcolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var b = new SolidBrush(colorDialog1.Color);
                Instrument.Brush = b;
            }
            ((Button)sender).BackColor = colorDialog1.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Instrument.Pen.Width = trackBar1.Value;
        }

        private void open_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                
                openFileDialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap B = new Bitmap(openFileDialog.FileName);
                    var img = new Bitmap(p.ContainerSize.Width, p.ContainerSize.Height, PixelFormat.Format24bppRgb);
                    Graphics.FromImage(img).Clear(Instrument.BackGround);
                    var ig = Graphics.FromImage(img);
                    ig.DrawImage(B, 0, 0);
                    Instrument.CurrentImage = img;
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
                SaveFileDialog saveFileDialog1   = new SaveFileDialog();
                saveFileDialog1.Filter           = "JPG (*.jpg)|.*jpg|  PNG (*.png)|.*png";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FilterIndex      = 2;
                //saveFileDialog1.AddExtension     = true;
                //saveFileDialog1.DefaultExt       = ".png";
                saveFileDialog1.OverwritePrompt  = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    {
                        var    path = SaveFileDialogFileTypeExtension.FileNameForceExtension(saveFileDialog1);
                            Bitmap b    = Instrument.CurrentImage as Bitmap;
                            Bitmap crop = b.Clone(
                                    new Rectangle(0, 0, panel1.Size.Width, panel1.Size.Height), b.PixelFormat);
                            crop.Save(path); 
                    }
                }
        }

        public static class SaveFileDialogFileTypeExtension
        {
            private static List<string> GetFileExtensions(string filter)
            {
                List<string> extensions = new List<string>();
                var          filtersRaw = filter.Split('|');
                for (int i = 0; i < filtersRaw.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        // Supporting multi doted extensions
                        extensions.Add(filtersRaw[i].Trim().Replace("*", "").Substring(1));
                    }
                }

                return extensions;
            }
            
            public static string FileNameForceExtension(SaveFileDialog dialog)
            {
                string fileName = dialog.FileName;
                // Retrieving the current selected filter index
                List<string> extensions        = GetFileExtensions(dialog.Filter);
                string       selectedExtension = extensions[dialog.FilterIndex - 1];
                // Adding extension if need it
                if (!fileName.EndsWith($".{selectedExtension}"))
                {
                    fileName = $"{fileName}.{selectedExtension}";
                }

                return fileName;
            }
        }

        private void text_Click(object sender, EventArgs e)
        {
            //  panel1.Controls.Add(new TextBox() { Location = new Point(100, 100), Text = "���� x", Size = new Size(30, 30) }); 
             p.InsType = Painter.InstrumentType.Text;
        }


        private void triangle_Click(object sender, EventArgs e)
        {
            p.InsType = Painter.InstrumentType.TriangleDrawer;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string? drawString = panel1.Controls[panel1.Controls.Count - 1].Text;
                    System.Drawing.Font         drawFont   = new System.Drawing.Font("Arial", Instrument.Pen.Width+14);
                    System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                    //formGraphics.DrawString(drawString, drawFont, Instrument.Brush, Instrument.TextLocation[i]);
                    Bitmap B   = new Bitmap(Instrument.CurrentImage);
                    var    img = new Bitmap(p.ContainerSize.Width, p.ContainerSize.Height, PixelFormat.Format24bppRgb);
                    Graphics.FromImage(img).Clear(Instrument.BackGround);
                    var ig = Graphics.FromImage(img);
                    ig.DrawImage(B, 0, 0);
                    ig.DrawString(drawString, drawFont, Instrument.Brush, Instrument.TextLocation[panel1.Controls.Count - 1], drawFormat);
                    Instrument.CurrentImage = img;
                    //Graphics.FromImage(Instrument.CurrentImage).DrawString(drawString, drawFont, Instrument.Brush, Instrument.TextLocation[i], drawFormat);
                    Instrument.TextLocation.RemoveAt(panel1.Controls.Count-1);
                    Instrument.Text.RemoveAt(panel1.Controls.Count-1);
                    this.panel1.Controls.RemoveAt(panel1.Controls.Count-1);
                    drawFont.Dispose();
                    //Graphics.FromImage(Instrument.CurrentImage).DrawLine(Instrument.Pen, Instrument.TextLocation[i], Instrument.TextLocation[i+1]);
                   // p.Paint(formGraphics);
                   
                // p.PaintText(p, panel1, panel1.CreateGraphics());
            }
        }
                /* p.Text = this.panel1.Controls[this.panel1.Controls.Count - 1].Text;
                 System.Drawing.Graphics formGraphics = this.CreateGraphics();
                 string drawString = p.Text;
                 System.Drawing.Font drawFont = new System.Drawing.Font("Arial", Instrument.Pen.Width);
                 //System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                 float x = 150.0F;
                 float y = 50.0F;
                 System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                 formGraphics.DrawString(drawString, drawFont, Instrument.Brush, , y, drawFormat);
                 drawFont.Dispose();
                 drawBrush.Dispose();
                 formGraphics.Dispose();
                 p.PaintVoid();
                 this.panel1.Controls.RemoveAt(panel1.Controls.Count - 1);*/

        private void CleanForm(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Dispose();
                    CleanForm(this);
                }

            }
        }
    }
}
