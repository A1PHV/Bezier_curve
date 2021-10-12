using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Bezie
{
    class Paint
    {
        Point p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;

        PointF p11, p22, p33, p44, p55, p66, p77, p88, p99, p100;

        int width, height;

        public float T = 0.1F;

        float prevx, prevy;

        Bitmap b;

        Graphics g;

        public List<Point> myWay = new List<Point>();

        public Paint(PictureBox p)
        {
            this.width = p.Width;

            this.height = p.Height;

            b = new Bitmap(width, height);

            g = Graphics.FromImage(b);

            p1 = new Point(0, 0);

            p2 = new Point(0, 0);

            p3 = new Point(0, 0);

            p4 = new Point(0, 0);

            p5 = new Point(0, 0);

            p6 = new Point(0, 0);

            p7 = new Point(0, 0);

            p8 = new Point(0, 0);

            p9 = new Point(0, 0);

            p10 = new Point(0, 0);
        }
        public void initializePoint(float x, float y )
        {
            p1 = new Point(x, y);
            p11.X = p1.x;
            p11.Y = p1.y;
        }

        public void initializePoint1(float x, float y)
        {
            p2 = new Point(x, y);
            p22.X = p2.x;
            p22.Y = p2.y;
        }
        public void initializePoint2(float x, float y)
        {
            p3 = new Point(x, y);
            p33.X = p3.x;
            p33.Y = p3.y;
        }
        public void initializePoint3(float x, float y)
        {
            p4 = new Point(x, y);
            p44.X = p4.x;
            p44.Y = p4.y;
        }
        public void initializePoint4()
        {
            p5 = new Point(p1.x + (p2.x - p1.x) * T, p1.y + (p2.y - p1.y) * T);
            p55.X = p5.x;
            p55.Y = p5.y;
        }
        public void initializePoint5()
        {
            p6 = new Point(p2.x + (p3.x - p2.x) * T, p2.y + (p3.y - p2.y) * T);
            p66.X = p6.x;
            p66.Y = p6.y;
        }

        public void initializePoint6()
        {
            p7 = new Point(p3.x + (p4.x - p3.x) * T, p3.y + (p4.y - p3.y) * T);
            p77.X = p7.x;
            p77.Y = p7.y;
        }

        public void initializePoint7()
        {
            p8 = new Point(p5.x + (p6.x - p5.x) * T, p5.y + (p6.y - p5.y) * T);
            p88.X = p8.x;
            p88.Y = p8.y;
        }

        public void initializePoint8()
        {
            p9 = new Point(p6.x + (p7.x - p6.x) * T, p6.y + (p7.y - p6.y) * T);
            p99.X = p9.x;
            p99.Y = p9.y;
        }

        public void initializePoint9()
        {
            p10 = new Point(p8.x + (p9.x - p8.x) * T, p8.y + (p9.y - p8.y) * T);
            p100.X = p10.x;
            p100.Y = p10.y;
        }

        public void getPrevXY(float x, float y)
        {
            prevx = x;

            prevy = y;
        }

        public void createNewPoint()
        {
            myWay.Add(new Point(prevx, prevy));
        }
        public void drawPrev()
        {
            foreach(Point p in myWay)
            {
                p.Show(g);
            }
        }

        public Image showImage()
        {
            g.Clear(Color.Black);

            p1.Show(g);

            p2.Show(g);

            //g.DrawLine(Pens.White, p11, p22);

            //g.DrawLine(Pens.White, p11, p33);

            //g.DrawLine(Pens.White, p22, p33);

            ////g.DrawLine(Pens.White, p55, p66);

            ////g.DrawLine(Pens.White, p66, p77);

            ////g.DrawLine(Pens.White, p88, p99);

            p3.Show(g);

            p4.Show(g);

            //p5.Show(g);

            //p6.Show(g);

            //p7.Show(g);

            //p8.Show(g);

            //p9.Show(g);

            p10.Show(g);

            initializePoint4();

            initializePoint5();

            initializePoint6();

            initializePoint7();

            initializePoint8();

            initializePoint9();

            getPrevXY(p10.x, p10.y);

            drawPrev();

            if(T > 1)
            {
                T -= 0.01F;
            }

            if(T < 0)
            {
                T += 0.01F;
            }

            return b;
        }

        
    }
}
