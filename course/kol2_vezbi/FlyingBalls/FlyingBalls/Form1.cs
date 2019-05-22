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

namespace FlyingBalls
{
    public partial class Form1 : Form
    {
        public BallDoc topcinja { get; set; }
        public int createBall { get; set; }
        public bool pause { get; set; }
        public string FileName { get; set; }

        public Form1()
        {
            InitializeComponent();
            topcinja = new BallDoc();
            createBall = 0;
            DoubleBuffered = true;
            pause = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            topcinja.draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int y = r.Next(menuStrip1.Height + toolStrip1.Height, Height - statusStrip1.Height-(Ball.Radius*2));
            if (createBall % 5 == 0) {
                topcinja.addBall(new Ball(new Point(0-Ball.Radius*2,y)));
            }
            check();
            createBall++;
            topcinja.Move();
            Invalidate(true); 
        }

        public void check()
        {
            for (int i = 0; i < topcinja.items.Count; i++)
            {
                if (topcinja.items[i].Center.X + Ball.Radius > this.Width) {
                    topcinja.items.RemoveAt(i);
                    topcinja.Misses++;
                }
            }
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Misses:{0}",topcinja.Misses);
            toolStripStatusLabel2.Text = string.Format("Points:{0}", topcinja.Points);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            topcinja.isHit(e.Location);
            Invalidate(true);
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pause) {
                timer1.Stop();
                pauseToolStripMenuItem.Text = "Start";
                pause = !pause;
            }
            else
            {
                timer1.Start();
                pauseToolStripMenuItem.Text = "Puase";
                pause = !pause;
            }
        }

        private void OpenFile() {
            timer1.Stop();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open file";
            dialog.Filter = "Open a file(*.bll)|*.bll";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                FileName = dialog.FileName;
                try {
                    using (FileStream stream = new FileStream(FileName,FileMode.Open)) {
                        IFormatter formater = new BinaryFormatter();
                        topcinja = (BallDoc)formater.Deserialize(stream);
                    }
                } catch (Exception e)
                {
                    MessageBox.Show("Cannot read " + FileName);
                    FileName = null;
                    return;
                }
                timer1.Start();
                Invalidate(true);
            }
        }

        private void SaveFile()
        {
            timer1.Stop();
            if (FileName == null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Save file";
                dialog.Filter = "Save a file(*.bll)|*.bll";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = dialog.FileName;

                }
            }
            if (FileName != null) { 
                using (FileStream stream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formater = new BinaryFormatter();
                    formater.Serialize(stream,topcinja);
                }
            }
            timer1.Start();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            topcinja = new BallDoc();
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
