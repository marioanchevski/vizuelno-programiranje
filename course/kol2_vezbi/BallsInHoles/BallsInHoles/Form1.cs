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

namespace BallsInHoles
{
    public partial class Form1 : Form
    {
        public BallDoc topcinja { get; set; }
        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string FileName { get; set; }

        public Form1()
        {
            InitializeComponent();
            topcinja = new BallDoc();
            DoubleBuffered = true;
            top = 20;
            left = 50;
            width = this.Width - 2 * left;
            height = this.Height - 7 * top;
            topcinja.GenerateHoleR(top, left, height, width);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Pen p = new Pen(Color.Black, 2);
            e.Graphics.DrawRectangle(p, top, left, width, height);
            topcinja.draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            topcinja.addBall(new Ball(e.Location));
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Count:{0}",topcinja.items.Count);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            topcinja.Move(top,left,height,width);
            topcinja.cout();
            Invalidate(true);
        }

        private void SaveFile() {
            if (FileName == null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Title";
                dialog.Filter = "Save a file (*.bll)|*.bll";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = dialog.FileName;

                }
            }
            if (FileName != null) {
                using (FileStream filestr = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter form = new BinaryFormatter();
                    form.Serialize(filestr, topcinja);
                }
            }
        }

        private void OpenFile() {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Title";
            dialog.Filter = "Open a file (*.bll)|*.bll";
            if (dialog.ShowDialog() == DialogResult.OK) {
                FileName = dialog.FileName;
                try
                {
                    using (FileStream filestr = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter form = new BinaryFormatter();
                        topcinja = (BallDoc)form.Deserialize(filestr);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Cant find " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }
}
