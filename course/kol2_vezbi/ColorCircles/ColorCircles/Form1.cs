using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorCircles
{
    public partial class Form1 : Form
    {

        public BallDoc topcinja { get; set; }
        public Point Start { get; set; }
        public Point currentPoint { get; set; }
        public Color currentColor { get; set;}
        public int Radius { get; set; }
        public bool firstClick { get; set; }
        public string FileName { get; set; }


        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            topcinja = new BallDoc();
            currentColor = Color.Green;
            firstClick = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (!Start.IsEmpty) {
                Pen p = new Pen(Color.Black, 3);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawEllipse(p, Start.X-Radius, Start.Y-Radius, 2 * Radius, 2 * Radius);
            }
            topcinja.draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { 
                if (Start.IsEmpty) {
                    Start = e.Location;
                    
                }
                else
                {
                    Ball b = new Ball(Start,currentColor, Radius);
                    topcinja.addBall(b);
                    Start = Point.Empty;
                    currentPoint = Point.Empty;
                    Invalidate(true);
                }
            }
            if (e.Button == MouseButtons.Right) {
                topcinja.isHit(e.Location);
                Invalidate(true);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
             
                currentPoint = e.Location;
                Radius = (int)Math.Sqrt(( currentPoint.X-Start.X) * (currentPoint.X - Start.X) + (currentPoint.Y-Start.Y)* (currentPoint.Y - Start.Y));
                Invalidate();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Start = Point.Empty;
            if (e.KeyCode == Keys.Left) {
                topcinja.Move(20,20, Ball.Direction.Left);
            }
            if (e.KeyCode == Keys.Down)
            {
                topcinja.Move(20, 20, Ball.Direction.Down);
            }
            if (e.KeyCode == Keys.Right)
            {
                topcinja.Move(20, 20, Ball.Direction.Right);
            }
            if (e.KeyCode == Keys.Up)
            {
                topcinja.Move(20, 20, Ball.Direction.Up);
            }
            if (e.KeyCode == Keys.Delete) {
                topcinja.delete();
            }

            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Count:{0}",topcinja.items.Count);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog diag = new ColorDialog();
            if (diag.ShowDialog() == DialogResult.OK) {
                currentColor = diag.Color;
            }
        }

        private void OpenFile() {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Title = "Open file";
            diag.Filter = "Open a file (*.bll)|*.bll";
            if (diag.ShowDialog() == DialogResult.OK) {
                FileName = diag.FileName;
                using (FileStream file = new FileStream(FileName, FileMode.Open)) {
                    IFormatter form = new BinaryFormatter();
                    topcinja = (BallDoc)form.Deserialize(file);
                }
                Invalidate(true);
            }
        }

        private void SaveFile() {
            if (FileName == null) {
                SaveFileDialog diag = new SaveFileDialog();
                diag.Title = "Save file";
                diag.Filter = "Save a file (*.bll)|*.bll";
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    FileName = diag.FileName;
                }
                }
            if (FileName != null) {
                using (FileStream file = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter form = new BinaryFormatter();
                    form.Serialize(file,topcinja);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }
}
