using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingRectangles
{
    [Serializable]
    public class Rectangle
    {
        public Point Location { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public STATE currentState { get; set; }


        public enum STATE {
            Still,
            Down,
            Right
        }

        public Rectangle(Point p,Color c)
        {
            Location = p;
            Color = c;
            Width = 100;
            Height = 50;
            currentState = STATE.Still;
        }

        public void draw(Graphics g) {
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, Location.X - 50, Location.Y - 25, Width, Height);
            b.Dispose();
        }

        public bool isHit(Point p) {
            return Math.Abs(Location.X - p.X) <= (Width / 2) && Math.Abs(Location.Y - p.Y) <= (Height / 2);
        }


        public void Down() {
            Location = new Point(Location.X, Location.Y + 30);
        }

        public void Right()
        {
            Location = new Point(Location.X + Width, Location.Y + (Height - Width));
            int tmp = Width;
            Width = Height;
            Height = tmp;
        }


        public void Move()
        {
            if (currentState==STATE.Down) 
                Down();
            if (currentState == STATE.Right)
                Right();
        }
    }
}
