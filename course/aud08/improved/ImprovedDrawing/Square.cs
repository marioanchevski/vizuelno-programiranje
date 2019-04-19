using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedDrawing
{
    public class Square : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Square(int x,int y, Color c):base(x,y,c){
            Width = 60;
            Height = 60;
        }

        public override void bounce(bool b)
        {
            if (canBounce) {
                if (b)
                    b1();
                else
                    b2();
            }
        }

        public override void draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            g.FillRectangle(b, X - Width / 2, Y - Height/2, Width, Height);
            if (Selected) {
                Pen p = new Pen(Color.Black, 4);
                g.DrawRectangle(p, X - Width / 2, Y - Height / 2, Width, Height);
                p.Dispose();
            }

            b.Dispose();
        }

        public void b1() {
            if (isBouncing)
            {
                Width -= 5;
                Height -= 5;
            }
            else {
                Width += 5;
                Height += 5;
            }
            if (Width < 20)
                isBouncing = false;
            if (Width > 100)
                isBouncing = true;
        }

        public void b2()
        {
            if (isBouncing)
            {
                Width += 5;
                Height -= 5;
            }
            else
            {
                Width -= 5;
                Height += 5;
            }
            if (Width < 20)
                isBouncing = true;
            if (Width > 100)
                isBouncing = false;
        }

        public override bool isHit(int x, int y)
        {
            return Math.Abs(X - x) <= (Width / 2) && Math.Abs(Y - y) <= (Height / 2);
        }

    }
}
