using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedDrawing
{
    public class ShapeList
    {
        public List<Shape> MyShapes { get; set; }
        public Shape selected { get; set; }

        public enum SHAPE_TYPE {
            Circle,
            Square,
            Triangle
        }

        public ShapeList()
        {
            MyShapes = new List<Shape>();
            selected = null;
        }

        public void addToList(int x,int y,Color c,SHAPE_TYPE type) {

            if (type == SHAPE_TYPE.Circle) {
                MyShapes.Add(new Circle(x,y, c));
            }
            if(type == SHAPE_TYPE.Square) {
                MyShapes.Add(new Square(x,y, c));
            }
            if (type == SHAPE_TYPE.Triangle)
            {
                MyShapes.Add(new Triangle(x-10,y-50, c,new Point(x+50,y),new Point(x,y+70)));
            }

        }

        public void remove(Shape s) {
            MyShapes.Remove(s);
        }

        public Shape isHit(int x, int y) {
            foreach (var s in MyShapes) {
                if (!(s is Triangle)) { 
                    if (s.isHit(x, y)) {
                        selected = s;
                        selected.Selected = !selected.Selected;
                        return selected;
                    }
                }
            }
            return null;
        }



        public void draw(Graphics g) {
            foreach (Shape s in MyShapes)
                s.draw(g);
        }

        public void clear()
        {
            MyShapes.Clear();

        }


        public void circleBounce(bool can) {
            if (can)
            {
                foreach (var c in MyShapes) {
                    if (c is Circle) { 
                    c.canBounce = true;
                    c.bounce(true);
                    }
                }
            }
            else {
                foreach (var c in MyShapes)
                    if (c is Circle)
                    c.canBounce = false;
            }
        }

        public void squareBoune(bool can) {
            bool alternate = true;
            if (can)
            {
                foreach (var s in MyShapes)
                {
                    if (s is Square) { 
                    s.canBounce = true;
                    s.bounce(alternate);
                    alternate = !alternate;
                    }
                }
            }
            else
            {
                foreach (var s in MyShapes)
                    if(s is Square)
                    s.canBounce = false;
            }
        }
    }
}
