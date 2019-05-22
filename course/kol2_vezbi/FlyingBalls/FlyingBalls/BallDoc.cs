using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBalls
{
    [Serializable]
    public class BallDoc
    {
        public List<Ball> items { get; set; }
        public int Misses { get; set; }
        public int Points { get; set; }

        public BallDoc() {
            items = new List<Ball>();
            Misses = 0;
            Points = 0;
        }

        public void draw(Graphics g) {
            foreach (var b in items) {
                b.draw(g);
            }
        }

        public void addBall(Ball b) {
            items.Add(b);
        }

        public void Move() {
            foreach (var b in items)
                b.Move();
        }

        public void isHit(Point p)
        {
            foreach (var b in items) {
                if (b.isHit(p))
                    b.State++;
            }
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].State >= 3)
                {
                    items.RemoveAt(i);
                    Points++;
                }
            }
            
        }

   
    }
}
