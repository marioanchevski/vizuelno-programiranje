using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersMaster
{
    public class Circle
    {
        public Point Center { get; set; }
        public static int Radius = 30;
        public char Letter { get; set; }
        public int Count { get; set; }
        public bool win { get; set; }


        public Circle(Point p)
        {
            Center = p;
            Random r = new Random();
            Letter = (char)r.Next(65,91);
            Count = 0;
            win = false;
        }

        public void draw(Graphics g) {
            Brush b = new SolidBrush(Color.LightGreen);
            Brush b3 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.Black);
            if (win)
            {
                g.FillEllipse(Brushes.Red, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
            else { 
            g.FillEllipse(b, Center.X-Radius, Center.Y-Radius, 2 * Radius, 2 * Radius);
            }
            g.DrawString(string.Format("{0}", Letter), new Font("Arial", 24), b2, Center.X - 15, Center.Y - 15);
            b2.Dispose();
            b.Dispose();
            b3.Dispose();
        }

        public void Move() {
            Center = new Point(Center.X, Center.Y + 10);
        }
    }
}
