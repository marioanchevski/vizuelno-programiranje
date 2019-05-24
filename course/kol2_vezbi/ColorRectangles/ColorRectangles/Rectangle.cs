using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorRectangles
{
    public class Rectangle
    {
        public Point Location { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool isSelected { get; set; }


        public Rectangle(Point p,Color c,int w,int h) {
            Location = p;
            Color = c;
            Width = w;
            Height = h;
            isSelected = false;
        }


        public void draw(Graphics g) {
            Brush b = new SolidBrush(Color);
            if (isSelected) {
                Pen p = new Pen(Color.Red, 3);
                g.DrawRectangle(p, Location.X, Location.Y, Width, Height);
                p.Dispose();
            }
            g.FillRectangle(b, Location.X, Location.Y, Width, Height);
            b.Dispose();
        }

        public bool isHit(Point p) {
            //return Math.Abs(Location.X - p.X) <= Width / 2 && Math.Abs(Location.Y - p.Y) <= Height / 2;
             return p.X >= Location.X && p.X <= Location.X + Width && p.Y >= Location.Y && p.Y <= Location.Y + Height;
            
        }
    }
}
