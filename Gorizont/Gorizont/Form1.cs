using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorizont
{
    public partial class Form1 : Form
    {
        double x = 0, y = 0;
        double a = 1;
        double t = 0;
        double V = 10;
        const double g = 9.8;
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            timer1.Interval = 50;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle((int)(50 * x), (int)(400 - 50 * y), 5, 5));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += 0.01;
            x = (V * Math.Cos(a)) * t;
            y = (V * Math.Sin(a)) * t - g * t * t / 2;
            this.Text = x.ToString() + " " + y.ToString();
            Invalidate();
        }
    }
}
