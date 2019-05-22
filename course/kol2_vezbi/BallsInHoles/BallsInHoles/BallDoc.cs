using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{

        [Serializable]
    public class BallDoc
    {
        public List<Ball> items { get; set; }
        public List<Hole> holes { get; set; }


        

        public void GenerateHoleR(int top,int left,int height,int width) {
            if (holes.Count == 5) return;
            Random r = new Random();
            int x = r.Next(top,width);
            int y = r.Next(left, height);
           
            bool touch = false;
            foreach (Hole h in holes) {
                if (h.touches(new Point(x, y)))
                {
                    touch = true;
                    break;
                }
            }

            if (!touch)
                holes.Add(new Hole(new Point(x,y)));
            GenerateHoleR(top,left,height,width);
        }
        
        public BallDoc() {
            items = new List<Ball>();
            holes = new List<Hole>();
        }

        public void draw(Graphics g) {
            foreach (var b in items)
                b.draw(g);
            foreach (var h in holes) {
                h.draw(g);
            }
        }

        public void addBall(Ball b) {
            items.Add(b);
        }

        public void Move(int top,int left,int height,int widht)
        {
            foreach (var b in items)
                b.move(top,left,height,widht);
        }

        public void cout() {
            for (int i = 0; i < items.Count; i++) {
                for (int j = 0; j < holes.Count; j++) {
                    if (items[i].isHit(holes[j])) {
                        items[i].isColided = true;
                        holes[j].Count++;
                    }
                }
            }

            for (int i = 0; i < items.Count; i++) {
                if (items[i].isColided)
                    items.RemoveAt(i);
            }
        }
    }
}
