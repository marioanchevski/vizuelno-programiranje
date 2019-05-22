using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    public  class BallDoc
    {
        public List<Ball> items { get; set; }


        public BallDoc() {
            items = new List<Ball>();
        }

        public void addBall(Ball b) {
            items.Add(b);
        }

        public void draw(Graphics g) {
            foreach (var b in items) {
                b.draw(g);
            }
            
        }

        public void pulse()
        {
            foreach (var b in items)
                b.pulse();
        }
    }
}
