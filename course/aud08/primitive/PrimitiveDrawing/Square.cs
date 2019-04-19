using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveDrawing
{
    public class Square : Shape
    {
        public int Width { get; set; }
        public int Height { set; get; }

        public Square(float x, float y) : base(x, y) {
            Width = 60;
            Height = 60;
        }

        public override void draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Blue);
            g.FillRectangle(b, X - Width/2, Y - Height/2, Width, Height);
            b.Dispose();
        }
    }
}
