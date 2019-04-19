using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveDrawing
{
    public class Triangle : Shape
    {
        public Point p2 { get; set; }
        public Point p3 { get; set; }
   

        public Triangle(float x, float y,Point p2,Point p3) : base(x, y) {
            this.p2 = p2;
            this.p3 = p3;
        }

        public override void draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Green);
            Point[] points = { new Point((int)X,(int)Y), p2, p3 };
            g.FillPolygon(b, points);
            b.Dispose();
        }
    }
}
