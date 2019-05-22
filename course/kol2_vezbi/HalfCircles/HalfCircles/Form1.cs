using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalfCircles
{
    public partial class Form1 : Form
    {
        public BallDoc topcinja { get; set; }
        public Form1()
        {
            InitializeComponent();
            topcinja = new BallDoc();
            DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            topcinja.draw(e.Graphics);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                topcinja.addBall(new Ball(e.Location));
                Invalidate(true);
            }
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Total:{0}",topcinja.items.Count);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            topcinja.pulse();
            Invalidate(true);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
