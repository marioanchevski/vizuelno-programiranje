using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    [Serializable]
    public class Hole
    {
        public Point Center { get; set; }
        public static int Radius = 25;
        public int Count { get; set; }

        public Hole(Point p) {
            Center = p;
            Count = 0;
        }

        public void draw(Graphics g) {
            Brush b = new SolidBrush(Color.Black);
            Brush b2 = new SolidBrush(Color.White);
            g.FillEllipse(b, Center.X, Center.Y, 2 * Radius, 2 * Radius);
            g.DrawString(string.Format("{0}", Count), new Font("Arial", 13), b2, Center.X+Radius/2, Center.Y+ Radius / 2);
            b.Dispose();
            b2.Dispose();
        }

        public bool touches(Point p) {
            return (Center.X - p.X) * (Center.X - p.X) + (Center.Y - p.Y) * (Center.Y - p.Y) <= 2 * Radius * 2 * Radius;
        }
    }
}
