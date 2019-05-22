using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    public class Ball
    {
        public Point Center { get; set; }
        public Color firstColor { get; set; }
        public Color secondColor { get; set; }
        public static int Radius = 30;
        

        public Ball(Point p) {
            firstColor = Color.Red;
            secondColor = Color.LightBlue;
            Center = p;
        }

        public void draw(Graphics g) {
            Brush b = new SolidBrush(firstColor);
            Brush b2 = new SolidBrush(secondColor);
            g.FillPie(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius, 0, 180);
            g.FillPie(b2, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius, 180, 180);
            b.Dispose();
            b2.Dispose();

        }

        public void pulse() {
            Radius += 3;
            if (Radius == 60)
                Radius = 30;
        }
    }
}
