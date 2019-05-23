using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
{
    public class BallDoc
    {
        public List<Ball> items { get; set; }

        public BallDoc()
        {
            items = new List<Ball>();
        }

        public void addBall(Ball b) {
            items.Add(b);
        }

        public void draw(Graphics g) {
            foreach (var b in items)
                b.draw(g);
        }

        public void work() {
            for (int i = 0; i < items.Count; i++) {
                items[i].sweep = items[i].sweep - 90;
                if (items[i].sweep == 0) {
                    items.RemoveAt(i);
                }
            }

          
        }
    }


}
