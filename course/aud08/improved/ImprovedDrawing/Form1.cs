using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImprovedDrawing
{
    public partial class Form1 : Form
    {
        public ShapeList list { get; set; }
        public SHAPE_TYPE type { get; set; }
        public Color currentColor { get; set; }
        public int prevX;
        public int prevY;
        Shape selected;

        public enum SHAPE_TYPE
        {
            Circle,
            Square,
            Triangle
        }


        public Form1()
        {
            InitializeComponent();
            list = new ShapeList();
            type = SHAPE_TYPE.Circle;
            currentColor = Color.Blue;
            circleToolStripMenuItem.Checked = true;
            this.DoubleBuffered = true;
            selected = null;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            list.draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            selected=list.isHit(e.X, e.Y);
            prevX = e.X;
            prevY = e.Y;
        }

        

        private void itemsClicked(object sender, EventArgs e)
        {
            if (sender == circleToolStripMenuItem)
            {
                circleToolStripMenuItem.Checked = true;
                squareToolStripMenuItem.Checked = false;
                triangleToolStripMenuItem.Checked = false;
                type = SHAPE_TYPE.Circle;
            }
            if (sender == squareToolStripMenuItem)
            {
                circleToolStripMenuItem.Checked = false;
                squareToolStripMenuItem.Checked = true;
                triangleToolStripMenuItem.Checked = false;
                type = SHAPE_TYPE.Square;
            }
            if (sender == triangleToolStripMenuItem)
            {
                circleToolStripMenuItem.Checked = false;
                squareToolStripMenuItem.Checked = false;
                triangleToolStripMenuItem.Checked = true;
                type = SHAPE_TYPE.Triangle;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK) {
                currentColor = color.Color;
            }
        }

        public void controlBounce() {
            if (circleToolStripMenuItem1.Checked)
                list.circleBounce(true);
            else
                list.circleBounce(false);

            if (squareToolStripMenuItem1.Checked)
                list.squareBoune(true);
            else
                list.squareBoune(false);
        }   


        private void bounceSelect(object sender, EventArgs e)
        {
            if (sender == circleToolStripMenuItem1) {
                if (circleToolStripMenuItem1.Checked)
                    circleToolStripMenuItem1.Checked = false;
                else  
                    circleToolStripMenuItem1.Checked = true;
                
            }
            if (sender == squareToolStripMenuItem1) {
                if (squareToolStripMenuItem1.Checked)
                    squareToolStripMenuItem1.Checked = false;       
                else
                    squareToolStripMenuItem1.Checked = true;
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
            controlBounce();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
        }

       

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            list.clear();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (type == SHAPE_TYPE.Circle)
            {
                list.addToList(e.X,e.Y, currentColor, ShapeList.SHAPE_TYPE.Circle);
            }
            if (type == SHAPE_TYPE.Square)
            {
                list.addToList(e.X, e.Y, currentColor, ShapeList.SHAPE_TYPE.Square);
            }
            if (type == SHAPE_TYPE.Triangle)
            {
                list.addToList(e.X, e.Y, currentColor, ShapeList.SHAPE_TYPE.Triangle);
            }
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (selected != null) {
                int dx =  e.X-prevX;
                int dy =  e.Y-prevY;
                 selected.move(dx,dy);
            }
            prevX = e.X;
            prevY = e.Y;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && selected != null) {
                list.remove(selected);
                Invalidate();
                selected = null;
            }
        }
    }
}
