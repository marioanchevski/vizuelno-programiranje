using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersMaster
{
    public class LettersDoc
    {
        public List<Circle> items { get; set; }
        public int misses { get; set; }
        public int points { get; set; }
        public int[] Count { get; set; }

        public LettersDoc() {
            items = new List<Circle>();
            misses = 0;
            points = 0;
            Count = new int[26];
        }

        public void addCircle(Circle c) {
            Count[c.Letter - 65]++;
            items.Add(c);
        }

        public void draw(Graphics g) {
            foreach (var c in items)
                c.draw(g);
        }

        public void Move()
        {
            foreach (var c in items)
                c.Move();

            for (int i = 0; i < items.Count; i++) {
                if (items[i].win)
                    items.RemoveAt(i);
            }
        }

        public void check(int height)
        {
            for(int i=0;i<items.Count;i++)
            {
                if (items[i].Center.Y > height - 25 && !items[i].win) {
                    items.RemoveAt(i);
                    misses++;
                }
            }
        }

        public void win(char c) {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Letter == Char.ToUpper(c))
                {
                    items[i].win = true;
                    points++;
                    break;
                }
            }
        }
    }
}
