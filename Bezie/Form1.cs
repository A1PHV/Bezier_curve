using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bezie
{
    public partial class Form1 : Form
    {
        Paint paint;

        public Form1()
        {
            InitializeComponent();
            paint = new Paint(pictureBox1);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = paint.showImage();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            float x1, x2, x3, x4;

            float y1, y2, y3, y4;

            if (e.Button == MouseButtons.Left)
            {
                x1 = e.X;
                y1 = e.Y;
                paint.initializePoint(x1, y1);
            }

            if (e.Button == MouseButtons.Right)
            {
                x2 = e.X;
                y2 = e.Y;
                paint.initializePoint1(x2, y2);
            }

            if (e.Button == MouseButtons.Middle)
            {
                x3 = e.X;
                y3 = e.Y;
                paint.initializePoint2(x3, y3);
            }

            if (e.Button == MouseButtons.XButton1)
            {
                x4 = e.X;
                y4 = e.Y;
                paint.initializePoint3(x4, y4);
            }    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            paint.T -= 0.01F;
            paint.createNewPoint();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paint.T += 0.01F;
            paint.createNewPoint();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paint.myWay.Clear();
        }
    }
}
