using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorRectangles
{
    public class RectangleDoc
    {
        public List<Rectangle> items { get; set; }

        public RectangleDoc() {
            items = new List<Rectangle>();
        }

        public void draw(Graphics g) {
            foreach (var r in items)
                r.draw(g);
        }

        public void addRectangle(Rectangle r) {
            items.Add(r);
        }

        public void isHit(Point p) {
           for(int i = 0; i < items.Count; i++) { 
                if (items[i].isHit(p)) {
                    items[i].isSelected = !items[i].isSelected;
                }
            }
        }

        public void delete() {
            for (int i = items.Count-1; i>=0; i--) {
                if (items[i].isSelected)
                    items.RemoveAt(i);
            }
        }
    }


}
