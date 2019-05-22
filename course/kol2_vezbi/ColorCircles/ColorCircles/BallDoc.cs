using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{[Serializable]
    public class BallDoc
    {
        public List<Ball> items { get; set; }

        public BallDoc() {
            items = new List<Ball>();
        }

        public void draw(Graphics g) {
            foreach (var b in items)
                b.draw(g);
        }

        public void addBall(Ball b)
        {
            items.Add(b);
        }

        public void isHit(Point p) {
            for (int i = 0; i < items.Count; i++) {
                if (items[i].isHit(p)) {
                    items[i].selected = !items[i].selected;
                    return;
                }
            }
        }

        public void Move(int x ,int y,Ball.Direction dir) {
            foreach (var t in items) {
                if (t.selected) {
                    t.move(x, y, dir);
                }
            }
        }

        public void delete() {
            items.Clear();
        }
    }
}
