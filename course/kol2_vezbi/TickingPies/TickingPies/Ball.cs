using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
{
    public class Ball
    {
        public Point Center { get; set; }
        public static int RADIUS = 25;
        public Color Color { get; set; }
        public int sweep { get; set; }

        public Ball(Point p,Color c) {
            Center = p;
            Color = c;
            sweep = 360;
        }

        public void draw(Graphics g) {
            Brush b = new SolidBrush(Color);
            g.FillPie(b,Center.X-RADIUS,Center.Y-RADIUS,2*RADIUS,2*RADIUS,0,sweep);
            b.Dispose();
        }
    }
}
