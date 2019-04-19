using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedDrawing
{
    public class Triangle : Shape
    {
        public Point p2 { get; set; }
        public Point p3 { get; set; }

        public Triangle(int x,int y, Color c,Point p2,Point p3) : base(x,y,c) {
            this.p2 = p2;
            this.p3 = p3;
        }

       

        public override void draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            Point[] points = { new Point(X,Y), p2, p3 };
            g.FillPolygon(b, points);
            b.Dispose();
        }

        public override void bounce(bool b)
        {
            throw new NotImplementedException();
        }

        public override bool isHit(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
