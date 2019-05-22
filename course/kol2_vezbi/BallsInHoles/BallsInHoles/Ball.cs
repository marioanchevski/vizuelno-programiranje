using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    [Serializable]
    public class Ball
    {
        public Point Location { get; set; }
        public static int Radius = 25;
        public double Velocity { get; set; }
        public double Angle { get; set; }
        public bool isColided { get; set; }

        public float VelocityX { get; set; }
        public float VelocityY { get; set; }
        Random rand = new Random();

        public Ball(Point p) {
            Location = p;
            Velocity = 25;
            isColided = false;
            Angle = rand.NextDouble()* 2 * Math.PI;
            VelocityX = (float)(Math.Cos(Angle) * Velocity);
            VelocityY = (float)(Math.Sin(Angle) * Velocity);
         
        }

        public void draw(Graphics g) {
            Brush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, Location.X - Radius, Location.Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
        }

        public void move(int top,int left,int height, int width) {
            float nextX = (Location.X + VelocityX);
            float nextY = (Location.Y + VelocityY);

            if (nextX + Radius <= left || nextX + Radius >= width + left)
                VelocityX = -VelocityX;
            if (nextY - Radius <= top || nextY - Radius >= height)
                VelocityY = -VelocityY;

            Location = new Point(Location.X + (int)VelocityX,Location.Y + (int)VelocityY);
        }


        public bool isHit(Hole p)
        {
            return (Location.X - p.Center.X) * (Location.X - p.Center.X) + (Location.Y - p.Center.Y) * (Location.Y - p.Center.Y) <= 2 * Radius * 2 * Radius;
        }
    }
}
