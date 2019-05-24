using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorRectangles
{
    public partial class Form1 : Form
    {
        public RectangleDoc rectangles { get; set; }
        public Color currentColor { get; set; }
        public Point previousPoint { get; set; }
        public Point currentPoint { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        int x, y;

        public Form1()
        {
            InitializeComponent();
            rectangles = new RectangleDoc();
            DoubleBuffered = true;
            currentColor = Color.Blue;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!previousPoint.IsEmpty) {
                Pen p = new Pen(Color.Black, 2);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(p, x, y, width, height);
            }
            rectangles.draw(e.Graphics);
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) { 
                if (previousPoint.IsEmpty)
                {
                    previousPoint = e.Location;
                }
                else {
                    rectangles.addRectangle( new Rectangle(new Point(x,y),currentColor,width,height));
                    previousPoint = Point.Empty;
                    currentPoint = Point.Empty;
                    Invalidate(true);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                rectangles.isHit(e.Location);
                Invalidate();
            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            x = previousPoint.X;
            y = previousPoint.Y;
            if (x > currentPoint.X) x = currentPoint.X;
            if (y > currentPoint.Y) y = currentPoint.Y;
            width = Math.Abs(previousPoint.X - currentPoint.X);
            height = Math.Abs(previousPoint.Y - currentPoint.Y);
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                previousPoint = Point.Empty;
            if (e.KeyCode == Keys.Delete)
                rectangles.delete();
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Total:{0}",rectangles.items.Count);
        }
    }
}
