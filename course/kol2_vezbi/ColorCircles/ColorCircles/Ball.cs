using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public int Radius { get; set; }
        public bool selected { get; set; }


        public enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }


        public Ball(Point p,Color c,int r)
        {
            Center = p;
            Color = c;
            Radius = r;
            selected = false;
        }

        public void draw(Graphics g) {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            if (selected) {
                Pen p = new Pen(Color.Black, 5);
                g.DrawEllipse(p, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                p.Dispose();
            }
            b.Dispose();
        }

        public bool isHit(Point p) {
            return (Center.X - p.X) * (Center.X - p.X) + (Center.Y - p.Y) * (Center.Y - p.Y) <= Radius*Radius*2*2;
        }

        public void move(int dx, int dy, Direction dir)
        {
            if (dir == Direction.Right)
            {

                Center = new Point(Center.X + dx, Center.Y);
            }
            if (dir == Direction.Left)
            {

                Center = new Point(Center.X - dx, Center.Y);
            }
            if (dir == Direction.Up)
            {
                Center = new Point(Center.X, Center.Y - dy);
            }
            if (dir == Direction.Down)
            {
                Center = new Point(Center.X, Center.Y + dy);
            }

        }
    }
}
