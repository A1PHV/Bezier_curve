using System;
using System.Drawing;

namespace Bezie
{
    class Point
    {
        public float x, y, R = 10;

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show(Graphics g)
        {
            g.FillEllipse(Brushes.White, x - R, y - R, 2 * R, 2 * R);
        }
    }
}
