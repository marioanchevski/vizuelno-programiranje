using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingRectangles
{
    [Serializable]
    public class RectangleDoc
    {
        public List<Rectangle> items { get; set; }

        public RectangleDoc() {
            items = new List<Rectangle>();
        }

        public void addRect(Rectangle r) {
            items.Add(r);
        }

        public void draw(Graphics g) {
            foreach (var r in items)
                r.draw(g);
        }
        

        public void check(int width,int height) {
            for (int i = 0; i < items.Count; i++) {
                if (items[i].Location.X > width || items[i].Location.Y>height) {
                    items.RemoveAt(i);
                }
            }
        }

        public void Move() {
            foreach (var r in items)
                r.Move();
        }

        public void StartMoving(Point p, Rectangle.STATE state) {
            foreach (var r in items) {
                if (r.isHit(p))
                {
                    if (r.currentState == Rectangle.STATE.Still)
                        r.currentState = state;
                }
            }
        }
        
    }
}
