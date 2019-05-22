using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettersMaster
{
    public partial class Form1 : Form
    {

        public LettersDoc game { get; set; }
        public int createCircle { get; set; }


        public Form1()
        {
            InitializeComponent();
            game = new LettersDoc();
            DoubleBuffered = true;
            createCircle = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            game.draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int x = r.Next(Circle.Radius, 840 - (2 * Circle.Radius));

            if (createCircle % 10 == 0) {

                game.addCircle(new Circle(new Point(x, 30)));
           
            }
            game.Move();
            game.check(this.Height);
            createCircle++;
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Misses:{0}",game.misses);
            toolStripStatusLabel2.Text = string.Format("Points:{0}", game.points);
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            game.win(e.KeyChar);
            Invalidate(true);
        }
    }
}
