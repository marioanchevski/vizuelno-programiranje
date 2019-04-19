using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedDrawing
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int x,int y, Color c) : base(x,y, c) {
            Radius = 30;
        }

        public override void bounce(bool b)
        {
            if (canBounce) { 
                if (isBouncing)
                    Radius += 3;
                else
                    Radius -= 3;
                if (Radius > 45)
                    isBouncing = false;
                if (Radius < 15)
                    isBouncing = true;
            }
        }

        public override void draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            g.FillEllipse(b, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            if (Selected) {
                Pen p = new Pen(Color.Black, 4);
                g.DrawEllipse(p, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
                p.Dispose();
            }
            b.Dispose();
        }

        public override bool isHit(int x, int y)
        {
            float diff = (X - x) * (X - x) + (Y - y) * (Y - y);
            return diff < Radius * Radius;
        }
    }
}
