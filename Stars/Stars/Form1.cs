using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.Red;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.White);
            e.Graphics.FillEllipse(pen.Brush, 40, 60, 20, 20);
            e.Graphics.FillEllipse(pen.Brush, 230, 40, 20, 20);
            e.Graphics.FillEllipse(pen.Brush, 50, 270, 20, 20);
            e.Graphics.FillEllipse(pen.Brush, 370, 70, 20, 20);
            e.Graphics.FillEllipse(pen.Brush, 230, 250, 20, 20);
            e.Graphics.FillEllipse(pen.Brush, 540, 315, 20, 20);
            e.Graphics.FillEllipse(pen.Brush, 545, 125, 20, 20);
            e.Graphics.FillEllipse(pen.Brush, 470, 190, 20, 20);

            Pen pen2 = new Pen(Color.Gray);
            Point[] point = { new Point(130, 90), new Point(115, 120), new Point(145, 120) };
            e.Graphics.FillPolygon(pen2.Brush, point);
            Point[] point2 = { new Point(130, 130), new Point(115, 100), new Point(145, 100) };
            e.Graphics.FillPolygon(pen2.Brush, point2);//6 burishty zhuldyz

            Point[] point3 = { new Point(200, 180), new Point(185, 210), new Point(215, 210) };
            e.Graphics.FillPolygon(pen2.Brush, point3);
            Point[] point4 = { new Point(200, 220), new Point(185, 190), new Point(215, 190) };
            e.Graphics.FillPolygon(pen2.Brush, point4);//6 burishty zhuldyz

            Point[] point5 = { new Point(400, 250), new Point(385, 280), new Point(415, 280) };
            e.Graphics.FillPolygon(pen2.Brush, point5);
            Point[] point6 = { new Point(400, 290), new Point(385, 260), new Point(415, 260) };
            e.Graphics.FillPolygon(pen2.Brush, point6);//6 burishty zhuldyz

            Point[] point7 = { new Point(470, 100), new Point(455, 130), new Point(485, 130) };
            e.Graphics.FillPolygon(pen2.Brush, point7);
            Point[] point8 = { new Point(470, 140), new Point(455, 110), new Point(485, 110) };
            e.Graphics.FillPolygon(pen2.Brush, point8);//6 burishty zhuldyz

            Pen pen3 = new Pen(Color.Yellow);
            Point[] point9 = { new Point(300, 170), new Point(360, 190), new Point(360, 230), new Point(300, 250), new Point(240, 230), new Point(240, 190), };
            e.Graphics.FillPolygon(pen3.Brush, point9);

            Pen pen4 = new Pen(Color.Green);
            Point[] point10 = { new Point(300, 190), new Point(310, 200), new Point(290, 200) };
            Point[] point11 = { new Point(296, 200), new Point(304, 200), new Point(304, 208), new Point(296, 208) };
            e.Graphics.FillPolygon(pen4.Brush, point10);
            e.Graphics.FillPolygon(pen4.Brush, point11);

            Point[] point12 = { new Point(330, 130), new Point(333, 140), new Point(343, 143), new Point(333, 146), new Point(330, 156), new Point(327, 146), new Point(317, 143), new Point(327, 140) };
            e.Graphics.FillPolygon(pen4.Brush, point12);
        }
    }
}
