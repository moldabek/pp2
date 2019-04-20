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

namespace Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen pen = new Pen(Color.White);
        int cnt = 0, end = 0, y;
        int color = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 700;
            
        }
        Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Gold, Color.Gray };
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            this.BackColor = Color.Black;

            Random ra = new Random();
            if(end == 1)
            {
                color = ra.Next(1, 40);
                end = 0;
                //y = ra.Next(1, 600);
            }
            
            if(color % 5 == 0)
            {
                pen = new Pen(Color.Red);
            }
            if (color % 5 == 1)
            {
                pen = new Pen(Color.Blue);
            }
            if (color % 5 == 2)
            {
                pen = new Pen(Color.White);
            }
            if (color % 5 == 3)
            {
                pen = new Pen(Color.Green);
            }
            if (color % 5 == 4)
            {
                pen = new Pen(Color.Cyan);
            }
            e.Graphics.FillEllipse(pen.Brush, 500, 0 + y, 40, 40);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y += 10;
            cnt++;
            if(y == 600)
            {
                y = 0;
            }
            if(cnt == 5)
            {
                end = 1;
                cnt = 1;
            }
            Refresh();
        }
    }
}
