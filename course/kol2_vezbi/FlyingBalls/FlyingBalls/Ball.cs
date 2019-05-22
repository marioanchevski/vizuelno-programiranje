using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBalls
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public static int Radius = 25;
        public Color Color { get; set; }
        public int State { get; set; }


        public Ball(Point p) {
            Center = p;
            Random r = new Random();
            State = r.Next(3);
        }

        public void draw(Graphics g) {
            if (State == 0)
                Color = Color.Green;
            if (State == 1)
                Color = Color.Blue;
            if (State == 2)
                Color = Color.Red;
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b,Center.X,Center.Y,2*Radius,2*Radius);
            b.Dispose();
        }


        public void Move() {
            Center = new Point(Center.X + 20, Center.Y);
        }

        public bool isHit(Point p) {
            return (Center.X - p.X) * (Center.X - p.X) + (Center.Y - p.Y) * (Center.Y - p.Y) <= (Radius *2) * (Radius*2);
        }
    }
}
