using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimitiveDrawing
{
    public partial class Form1 : Form
    {
        ShapeList lista;
        SHAPE_TYPE type;


        public enum SHAPE_TYPE {
            Circle,
            Square,
            Triangle
        }

        public Form1()
        {
            lista = new ShapeList();
            InitializeComponent();
            type = SHAPE_TYPE.Circle;
            circleToolStripMenuItem.Checked = true;
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            lista.draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (type == SHAPE_TYPE.Circle) {
                lista.addToList(e.X, e.Y,ShapeList.SHAPE_TYPE.Circle);
            }

            if (type == SHAPE_TYPE.Square)
            {
                lista.addToList(e.X, e.Y, ShapeList.SHAPE_TYPE.Square);
            }

            if (type == SHAPE_TYPE.Triangle)
            {
                lista.addToList(e.X, e.Y, ShapeList.SHAPE_TYPE.Triangle);
            }
            Invalidate();

        }


        private void menuItemClicked(object sender, EventArgs e)
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
    }
}
