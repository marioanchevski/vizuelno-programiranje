using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacmann
{
    public class Pacman
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static int Radius { get; set; }
        public int Speed { get; set; }
        public bool isMouthOpen { get; set; }
        public DIRECTION Nasoka { get; set; }

        public enum DIRECTION {
            Gore,
            Dole,
            Levo,
            Desno
        }

        public Pacman() {
            X = 280;
            Y = 200;
            Radius = 20;
            Speed = Radius;
            Nasoka = DIRECTION.Desno;
            isMouthOpen = false;
        }

        public void ChangeDirection(DIRECTION direction)
        {
            Nasoka = direction;
        }

        public void Move(int dx,int dy)
        {
            if (Nasoka == DIRECTION.Desno) {
                if (X >= 560)
                    X = 0;
                else
                    X += dx;
                
            }
            if (Nasoka == DIRECTION.Levo)
            {
                X -= dx;
                if (X < 0)
                    X = 560;
            }
            if (Nasoka == DIRECTION.Gore)
            {
                Y -= dx;
                if (Y < 0)
                    Y=340;
            }
            if (Nasoka == DIRECTION.Dole)
            {
                Y += dx;
                if (Y >= 360)
                    Y = 0;
            }
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Yellow);
            if (isMouthOpen)
            {
                if (Nasoka == DIRECTION.Desno) {
                    g.FillPie(b, X, Y, 2 * Radius, 2 * Radius, 30, 300);
                }
                if (Nasoka == DIRECTION.Levo) {
                    g.FillPie(b, X, Y, 2 * Radius, 2 * Radius, 210, 300);
                }
                if (Nasoka == DIRECTION.Gore) {
                    g.FillPie(b, X, Y, 2 * Radius, 2 * Radius, 300, 300);
                }
                if (Nasoka == DIRECTION.Dole) {
                    g.FillPie(b, X, Y, 2 * Radius, 2 * Radius, 120, 300);
                }
            }
            else
            {
                g.FillEllipse(b, X, Y, 2 * Radius, 2 * Radius);
            }
            b.Dispose();
        }
    }
}
