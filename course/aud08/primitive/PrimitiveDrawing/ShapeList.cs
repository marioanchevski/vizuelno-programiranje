using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimitiveDrawing
{
   public  class ShapeList
    {
        public List<Shape> MyShapes { get; set; }

        public enum SHAPE_TYPE {
            Circle,
            Triangle,
            Square
        }

        public ShapeList() {
            MyShapes = new List<Shape>();
        }

        public void addToList(float x,float y,SHAPE_TYPE type)
        {
            if (type == SHAPE_TYPE.Circle) {
                MyShapes.Add(new Circle(x, y));
            } else if (type == SHAPE_TYPE.Square)
            {
                MyShapes.Add(new Square(x, y));
            } else if (type == SHAPE_TYPE.Triangle)
            {
                MyShapes.Add( new Triangle(x-10,y-50,
                   new Point((int)x + 50, (int)y),
                   new Point((int)x, (int)y + 70)));
            }
        }

        public void draw(Graphics g) {
            foreach (Shape s in MyShapes)
                s.draw(g);
        }
    }
}
