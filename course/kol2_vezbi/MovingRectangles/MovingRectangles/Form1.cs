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

namespace MovingRectangles
{
    public partial class Form1 : Form
    {
        public RectangleDoc rectangles { get; set; }
        public Color currentColor { get; set; }
        public string FileName { get; set; }

        public Form1()
        {
            InitializeComponent();
            rectangles = new RectangleDoc();
            currentColor = Color.Red;
            DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            rectangles.draw(e.Graphics);

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            rectangles.addRect(new Rectangle(e.Location, currentColor));
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("num-Rectangles:{0}",rectangles.items.Count);
            toolStripStatusLabel2.Text= string.Format("Color:{0}", currentColor.Name);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                currentColor = dialog.Color;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangles.Move();
            rectangles.check(this.Width,this.Height);
            Invalidate(true);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                rectangles.StartMoving(e.Location, Rectangle.STATE.Down);
            }
            if (e.Button == MouseButtons.Right) {
                rectangles.StartMoving(e.Location, Rectangle.STATE.Right);
            }
            Invalidate();
            
        }

        private void SaveFile() {
            if (FileName == null) {
                SaveFileDialog dialog= new SaveFileDialog();
                dialog.Filter = "Rectangle file (*.rtg)|*.rtg";
                dialog.Title = "Save this file";
                dialog.FileName = FileName;
                if (dialog.ShowDialog() == DialogResult.OK) {
                    FileName = dialog.FileName;
                }
            }
            if (FileName != null) {
                using (FileStream stream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter from = new BinaryFormatter();
                    from.Serialize(stream, rectangles);   
                }
            }
        }


        private void OpenFile() {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Open rectange file(*.rtg)|*.rtg";
            dialog.Title = "Open a file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileName = dialog.FileName;
                try {
                    using (FileStream stream = new FileStream(FileName, FileMode.Open)) {
                        IFormatter from = new BinaryFormatter();
                        rectangles = (RectangleDoc)from.Deserialize(stream);
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rectangles = new RectangleDoc();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectangles = new RectangleDoc();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }
}
