using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickingPies
{
    public partial class Form1 : Form
    {
        public BallDoc topcinja { get; set; }
        public Color currentColor { get; set; }
        public bool pause { get; set; }

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            topcinja = new BallDoc();
            currentColor = Color.Blue;
            pause = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            topcinja.draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            topcinja.addBall(new Ball(e.Location, currentColor));
            Invalidate(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            topcinja.work();
            Invalidate(true);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pause) { 
                timer1.Start();
                startToolStripMenuItem.Text = "stop";
            }
            else
            {
                timer1.Stop();
                startToolStripMenuItem.Text = "start";
            }
            pause = !pause;

        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Total:{0}",topcinja.items.Count);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog diag = new ColorDialog();
            if (diag.ShowDialog() == DialogResult.OK) {
                currentColor = diag.Color;
            }
        }
    }
}
