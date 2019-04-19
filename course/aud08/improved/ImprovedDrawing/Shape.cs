using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedDrawing
{
   public abstract class Shape
    {
        public Point P { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Color color { get; set; }
        public bool isBouncing { set; get;}
        public bool canBounce { set; get; }
        public bool Selected { get; set; }


        public Shape(int x,int y,Color color) {
            X = x;
            Y = y;
            this.color = color;
            isBouncing = true;
            canBounce = false;
            Selected = false;
        }

        public abstract void draw(Graphics g);
        public abstract void bounce(bool b);
        public abstract bool isHit(int x, int y);


        public void move(int dx, int dy) {
            if (Selected) {
                X += dx;
                Y += dy;
            }
        }
    }
}
