using System.Windows.Forms;

namespace MyPaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.triangle = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Button();
            this.fillcolor = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Button();
            this.thikness = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pipetka = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.prncil = new System.Windows.Forms.Button();
            this.straight = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.gray_color = new System.Windows.Forms.Button();
            this.orange_color = new System.Windows.Forms.Button();
            this.maroon_color = new System.Windows.Forms.Button();
            this.plum_color = new System.Windows.Forms.Button();
            this.aqua_color = new System.Windows.Forms.Button();
            this.teal_color = new System.Windows.Forms.Button();
            this.crimson_color = new System.Windows.Forms.Button();
            this.silver_color = new System.Windows.Forms.Button();
            this.coral_color = new System.Windows.Forms.Button();
            this.purple_color = new System.Windows.Forms.Button();
            this.pink_color = new System.Windows.Forms.Button();
            this.blue_color = new System.Windows.Forms.Button();
            this.green_color = new System.Windows.Forms.Button();
            this.black_color = new System.Windows.Forms.Button();
            this.red_color = new System.Windows.Forms.Button();
            this.white_color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 376);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.triangle);
            this.panel2.Controls.Add(this.text);
            this.panel2.Controls.Add(this.fillcolor);
            this.panel2.Controls.Add(this.background);
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.open);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.color);
            this.panel2.Controls.Add(this.thikness);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.pipetka);
            this.panel2.Controls.Add(this.rectangle);
            this.panel2.Controls.Add(this.eraser);
            this.panel2.Controls.Add(this.prncil);
            this.panel2.Controls.Add(this.straight);
            this.panel2.Controls.Add(this.circle);
            this.panel2.Controls.Add(this.gray_color);
            this.panel2.Controls.Add(this.orange_color);
            this.panel2.Controls.Add(this.maroon_color);
            this.panel2.Controls.Add(this.plum_color);
            this.panel2.Controls.Add(this.aqua_color);
            this.panel2.Controls.Add(this.teal_color);
            this.panel2.Controls.Add(this.crimson_color);
            this.panel2.Controls.Add(this.silver_color);
            this.panel2.Controls.Add(this.coral_color);
            this.panel2.Controls.Add(this.purple_color);
            this.panel2.Controls.Add(this.pink_color);
            this.panel2.Controls.Add(this.blue_color);
            this.panel2.Controls.Add(this.green_color);
            this.panel2.Controls.Add(this.black_color);
            this.panel2.Controls.Add(this.red_color);
            this.panel2.Controls.Add(this.white_color);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 131);
            this.panel2.TabIndex = 0;
            // 
            // triangle
            // 
            this.triangle.BackColor = System.Drawing.Color.White;
            this.triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangle.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.triangle.ForeColor = System.Drawing.Color.Black;
            this.triangle.Image = ((System.Drawing.Image)(resources.GetObject("triangle.Image")));
            this.triangle.Location = new System.Drawing.Point(470, 69);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(72, 52);
            this.triangle.TabIndex = 1;
            this.triangle.Text = "Triangle";
            this.triangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.triangle.UseVisualStyleBackColor = false;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.White;
            this.text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text.ForeColor = System.Drawing.Color.Black;
            this.text.Image = ((System.Drawing.Image)(resources.GetObject("text.Image")));
            this.text.Location = new System.Drawing.Point(548, 70);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(70, 51);
            this.text.TabIndex = 0;
            this.text.Text = "Text";
            this.text.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.text.UseVisualStyleBackColor = false;
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // fillcolor
            // 
            this.fillcolor.BackColor = System.Drawing.Color.White;
            this.fillcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillcolor.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fillcolor.ForeColor = System.Drawing.Color.Black;
            this.fillcolor.Location = new System.Drawing.Point(702, 58);
            this.fillcolor.Name = "fillcolor";
            this.fillcolor.Size = new System.Drawing.Size(90, 47);
            this.fillcolor.TabIndex = 30;
            this.fillcolor.Text = "Fill color";
            this.fillcolor.UseVisualStyleBackColor = false;
            this.fillcolor.Click += new System.EventHandler(this.fillcolor_Click);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.White;
            this.background.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.background.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.background.ForeColor = System.Drawing.Color.Black;
            this.background.Location = new System.Drawing.Point(702, 6);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(90, 46);
            this.background.TabIndex = 29;
            this.background.Text = "Background color";
            this.background.UseVisualStyleBackColor = false;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.BackColor = System.Drawing.Color.White;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.Color.Black;
            this.clear.Location = new System.Drawing.Point(803, 76);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 29);
            this.clear.TabIndex = 28;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // open
            // 
            this.open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.open.BackColor = System.Drawing.Color.White;
            this.open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.ForeColor = System.Drawing.Color.Black;
            this.open.Location = new System.Drawing.Point(803, 41);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(94, 29);
            this.open.TabIndex = 27;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save.BackColor = System.Drawing.Color.White;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(803, 6);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 29);
            this.save.TabIndex = 26;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.White;
            this.color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("color.BackgroundImage")));
            this.color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.color.ForeColor = System.Drawing.Color.Black;
            this.color.Location = new System.Drawing.Point(182, 37);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(56, 59);
            this.color.TabIndex = 25;
            this.color.Text = "Color";
            this.color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.color.UseVisualStyleBackColor = false;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // thikness
            // 
            this.thikness.AutoSize = true;
            this.thikness.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thikness.Location = new System.Drawing.Point(251, 108);
            this.thikness.Name = "thikness";
            this.thikness.Size = new System.Drawing.Size(135, 23);
            this.thikness.TabIndex = 24;
            this.thikness.Text = "Change thikness";
            this.thikness.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(244, 70);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(189, 56);
            this.trackBar1.TabIndex = 23;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pipetka
            // 
            this.pipetka.BackColor = System.Drawing.Color.White;
            this.pipetka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipetka.BackgroundImage")));
            this.pipetka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pipetka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.pipetka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pipetka.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pipetka.ForeColor = System.Drawing.Color.Black;
            this.pipetka.Location = new System.Drawing.Point(624, 6);
            this.pipetka.Name = "pipetka";
            this.pipetka.Size = new System.Drawing.Size(72, 61);
            this.pipetka.TabIndex = 22;
            this.pipetka.Text = "Pipetka";
            this.pipetka.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pipetka.UseVisualStyleBackColor = false;
            this.pipetka.Click += new System.EventHandler(this.pipetka_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.White;
            this.rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangle.BackgroundImage")));
            this.rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rectangle.ForeColor = System.Drawing.Color.Black;
            this.rectangle.Location = new System.Drawing.Point(548, 5);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(70, 61);
            this.rectangle.TabIndex = 21;
            this.rectangle.Text = "Rectangle";
            this.rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.Color.White;
            this.eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraser.BackgroundImage")));
            this.eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraser.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eraser.ForeColor = System.Drawing.Color.Black;
            this.eraser.Location = new System.Drawing.Point(244, 5);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(70, 60);
            this.eraser.TabIndex = 20;
            this.eraser.Text = "Eraser";
            this.eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eraser.UseVisualStyleBackColor = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // prncil
            // 
            this.prncil.BackColor = System.Drawing.Color.White;
            this.prncil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prncil.BackgroundImage")));
            this.prncil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.prncil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.prncil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prncil.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prncil.ForeColor = System.Drawing.Color.Black;
            this.prncil.Location = new System.Drawing.Point(320, 5);
            this.prncil.Name = "prncil";
            this.prncil.Size = new System.Drawing.Size(66, 60);
            this.prncil.TabIndex = 19;
            this.prncil.Text = "Pencil";
            this.prncil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.prncil.UseVisualStyleBackColor = false;
            this.prncil.Click += new System.EventHandler(this.prncil_Click);
            // 
            // straight
            // 
            this.straight.BackColor = System.Drawing.Color.White;
            this.straight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("straight.BackgroundImage")));
            this.straight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.straight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.straight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.straight.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.straight.ForeColor = System.Drawing.Color.Black;
            this.straight.Location = new System.Drawing.Point(392, 4);
            this.straight.Name = "straight";
            this.straight.Size = new System.Drawing.Size(72, 61);
            this.straight.TabIndex = 18;
            this.straight.Text = "Straight";
            this.straight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.straight.UseVisualStyleBackColor = false;
            this.straight.Click += new System.EventHandler(this.straight_Click);
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.White;
            this.circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle.BackgroundImage")));
            this.circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circle.ForeColor = System.Drawing.Color.Black;
            this.circle.Location = new System.Drawing.Point(470, 5);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(72, 60);
            this.circle.TabIndex = 17;
            this.circle.Text = "Circle";
            this.circle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.circle.UseVisualStyleBackColor = false;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // gray_color
            // 
            this.gray_color.BackColor = System.Drawing.Color.Gray;
            this.gray_color.Location = new System.Drawing.Point(182, 3);
            this.gray_color.Name = "gray_color";
            this.gray_color.Size = new System.Drawing.Size(28, 27);
            this.gray_color.TabIndex = 15;
            this.gray_color.UseVisualStyleBackColor = false;
            this.gray_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // orange_color
            // 
            this.orange_color.BackColor = System.Drawing.Color.Orange;
            this.orange_color.Location = new System.Drawing.Point(148, 69);
            this.orange_color.Name = "orange_color";
            this.orange_color.Size = new System.Drawing.Size(28, 28);
            this.orange_color.TabIndex = 14;
            this.orange_color.UseVisualStyleBackColor = false;
            this.orange_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // maroon_color
            // 
            this.maroon_color.BackColor = System.Drawing.Color.Maroon;
            this.maroon_color.Location = new System.Drawing.Point(148, 36);
            this.maroon_color.Name = "maroon_color";
            this.maroon_color.Size = new System.Drawing.Size(28, 27);
            this.maroon_color.TabIndex = 13;
            this.maroon_color.UseVisualStyleBackColor = false;
            this.maroon_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // plum_color
            // 
            this.plum_color.BackColor = System.Drawing.Color.Plum;
            this.plum_color.Location = new System.Drawing.Point(148, 3);
            this.plum_color.Name = "plum_color";
            this.plum_color.Size = new System.Drawing.Size(28, 27);
            this.plum_color.TabIndex = 12;
            this.plum_color.UseVisualStyleBackColor = false;
            this.plum_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // aqua_color
            // 
            this.aqua_color.BackColor = System.Drawing.Color.Aqua;
            this.aqua_color.Location = new System.Drawing.Point(114, 70);
            this.aqua_color.Name = "aqua_color";
            this.aqua_color.Size = new System.Drawing.Size(28, 27);
            this.aqua_color.TabIndex = 11;
            this.aqua_color.UseVisualStyleBackColor = false;
            this.aqua_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // teal_color
            // 
            this.teal_color.BackColor = System.Drawing.Color.Teal;
            this.teal_color.ForeColor = System.Drawing.Color.Teal;
            this.teal_color.Location = new System.Drawing.Point(114, 37);
            this.teal_color.Name = "teal_color";
            this.teal_color.Size = new System.Drawing.Size(28, 26);
            this.teal_color.TabIndex = 10;
            this.teal_color.UseVisualStyleBackColor = false;
            this.teal_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // crimson_color
            // 
            this.crimson_color.BackColor = System.Drawing.Color.Crimson;
            this.crimson_color.ForeColor = System.Drawing.Color.Crimson;
            this.crimson_color.Location = new System.Drawing.Point(114, 3);
            this.crimson_color.Name = "crimson_color";
            this.crimson_color.Size = new System.Drawing.Size(28, 27);
            this.crimson_color.TabIndex = 9;
            this.crimson_color.UseVisualStyleBackColor = false;
            this.crimson_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // silver_color
            // 
            this.silver_color.BackColor = System.Drawing.Color.Silver;
            this.silver_color.Location = new System.Drawing.Point(80, 69);
            this.silver_color.Name = "silver_color";
            this.silver_color.Size = new System.Drawing.Size(28, 28);
            this.silver_color.TabIndex = 8;
            this.silver_color.UseVisualStyleBackColor = false;
            this.silver_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // coral_color
            // 
            this.coral_color.BackColor = System.Drawing.Color.Coral;
            this.coral_color.Location = new System.Drawing.Point(80, 37);
            this.coral_color.Name = "coral_color";
            this.coral_color.Size = new System.Drawing.Size(28, 26);
            this.coral_color.TabIndex = 7;
            this.coral_color.UseVisualStyleBackColor = false;
            this.coral_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // purple_color
            // 
            this.purple_color.BackColor = System.Drawing.Color.Purple;
            this.purple_color.Location = new System.Drawing.Point(80, 3);
            this.purple_color.Name = "purple_color";
            this.purple_color.Size = new System.Drawing.Size(28, 27);
            this.purple_color.TabIndex = 6;
            this.purple_color.UseVisualStyleBackColor = false;
            this.purple_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // pink_color
            // 
            this.pink_color.BackColor = System.Drawing.Color.Pink;
            this.pink_color.Location = new System.Drawing.Point(46, 70);
            this.pink_color.Name = "pink_color";
            this.pink_color.Size = new System.Drawing.Size(28, 27);
            this.pink_color.TabIndex = 5;
            this.pink_color.UseVisualStyleBackColor = false;
            this.pink_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // blue_color
            // 
            this.blue_color.BackColor = System.Drawing.Color.Blue;
            this.blue_color.Location = new System.Drawing.Point(46, 36);
            this.blue_color.Name = "blue_color";
            this.blue_color.Size = new System.Drawing.Size(28, 28);
            this.blue_color.TabIndex = 1;
            this.blue_color.UseVisualStyleBackColor = false;
            this.blue_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // green_color
            // 
            this.green_color.BackColor = System.Drawing.Color.Green;
            this.green_color.Location = new System.Drawing.Point(12, 70);
            this.green_color.Name = "green_color";
            this.green_color.Size = new System.Drawing.Size(28, 27);
            this.green_color.TabIndex = 4;
            this.green_color.UseVisualStyleBackColor = false;
            this.green_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // black_color
            // 
            this.black_color.BackColor = System.Drawing.Color.Black;
            this.black_color.Location = new System.Drawing.Point(46, 3);
            this.black_color.Name = "black_color";
            this.black_color.Size = new System.Drawing.Size(28, 27);
            this.black_color.TabIndex = 3;
            this.black_color.UseVisualStyleBackColor = false;
            this.black_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // red_color
            // 
            this.red_color.BackColor = System.Drawing.Color.Red;
            this.red_color.Location = new System.Drawing.Point(12, 36);
            this.red_color.Name = "red_color";
            this.red_color.Size = new System.Drawing.Size(28, 27);
            this.red_color.TabIndex = 2;
            this.red_color.UseVisualStyleBackColor = false;
            this.red_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // white_color
            // 
            this.white_color.BackColor = System.Drawing.Color.White;
            this.white_color.ForeColor = System.Drawing.Color.Black;
            this.white_color.Location = new System.Drawing.Point(12, 3);
            this.white_color.Name = "white_color";
            this.white_color.Size = new System.Drawing.Size(28, 27);
            this.white_color.TabIndex = 1;
            this.white_color.UseVisualStyleBackColor = false;
            this.white_color.Click += new System.EventHandler(this.white_color_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(340, 384);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button green_color;
        private Button black_color;
        private Button red_color;
        private Button white_color;
        private Button blue_color;
        private Button gray_color;
        private Button orange_color;
        private Button maroon_color;
        private Button plum_color;
        private Button aqua_color;
        private Button teal_color;
        private Button crimson_color;
        private Button silver_color;
        private Button coral_color;
        private Button purple_color;
        private Button pink_color;
        private Button eraser;
        private Button prncil;
        private Button straight;
        private Button circle;
        private TrackBar trackBar1;
        private Button pipetka;
        private Button rectangle;
        private Label thikness;
        private Button color;
        private ColorDialog colorDialog1;
        private Button clear;
        private Button open;
        private Button save;
        private SaveFileDialog saveFileDialog1;
        private Button background;
        private Button fillcolor;
        private Button text;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button triangle;
        private OpenFileDialog openFileDialog1;
    }
}