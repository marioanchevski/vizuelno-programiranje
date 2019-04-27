using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab06
{
    public partial class Form1 : Form
    {
        public Ravenka MyRavenka { get; set; }
        public List<Igrac> igraci { get; set; }
        int osvoeniPoeni = 0;
        int seconds = 00;
        int minutes = 1;
       
        public Form1()
        {
            InitializeComponent();
            progressBar2.Value = 0;
            MyRavenka = null;
            igraci = new List<Igrac>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (minutes>0 && seconds == 0)
            {
                seconds = 59;
                minutes--;
            }

            lblVreme.Text = String.Format("{0:00}:{1:00}", minutes, seconds);
            
            if (minutes == 0 && seconds == 0) {
                 lblVreme.Text = String.Format("{0:00}:{1:00}", minutes, seconds);
                timer1.Stop();
                progressBar2.Value--;
                btnPogodi.Enabled = false;
                MessageBox.Show("tolku!!\tOsvoivte "+osvoeniPoeni+" poeni!");
                igraci.Add(new Igrac(tbIgrac.Text, osvoeniPoeni));
                return;
            }
            seconds--;
            progressBar2.Value--;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbIgrac.Text == "") {
                MessageBox.Show("Vnesete ime!");
                return;
            }

            resetValues();
            timer1.Start();

            MyRavenka = new Ravenka();
            tbOperand1.Text = MyRavenka.Operand1.ToString();
            tbOperand2.Text = MyRavenka.Operand2.ToString();
            tbOperator.Text = MyRavenka.CurrentZnak.ToString();
            btnPogodi.Enabled = true;
        }

        public void resetValues() {
            osvoeniPoeni = 0;
            lblPoeni.Text = osvoeniPoeni.ToString();
            progressBar2.Value = 60;
            minutes = 1;
            seconds = 00;
            lblVreme.Text = String.Format("{0:00}:{1:00}", minutes, seconds);
        }

        private void btnPogodi_Click(object sender, EventArgs e)
        {
            checkResult();


            if (osvoeniPoeni % 10 == 0) 
                bonus();


            MyRavenka = new Ravenka();
            tbOperand1.Text = MyRavenka.Operand1.ToString();
            tbOperand2.Text = MyRavenka.Operand2.ToString();
            tbOperator.Text = MyRavenka.CurrentZnak.ToString();

        }

        public void bonus() {
            if (seconds + 10 > 60)
            {
                minutes = 1;
                seconds = 00;
            }
            else {
                seconds += 10;
            }
            if (progressBar2.Value + 10 > 60)
            {
                progressBar2.Value = 60;
            }
            else {
                progressBar2.Value += 10;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bonus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void checkResult()
        {
            int rezultat = 0;
            int myRez = 0;
            if (tbOperator.Text == "+")
            {
                rezultat = Convert.ToInt32(tbOperand1.Text) + Convert.ToInt32(tbOperand2.Text);
            }
            if (tbOperator.Text == "-")
            {
                rezultat = Convert.ToInt32(tbOperand1.Text) - Convert.ToInt32(tbOperand2.Text);
            }
            if (tbOperator.Text == "*")
            {
                rezultat = Convert.ToInt32(tbOperand1.Text) * Convert.ToInt32(tbOperand2.Text);
            }
            if (tbOperator.Text == "/")
            {
                rezultat = Convert.ToInt32(tbOperand1.Text) / Convert.ToInt32(tbOperand2.Text);
            }
            int.TryParse(tbRez.Text, out myRez);
            if (myRez == rezultat)
            {
                progressBar1.Value += 1;
                osvoeniPoeni++;
                lblPoeni.Text = osvoeniPoeni.ToString();
            }
            tbRez.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            igraci = igraci.OrderByDescending(x => x.Points).ToList();
            string lista = "";
            foreach (var i in igraci) {
                lista += i.Name + " " + i.Points + "\n";
            }
            MessageBox.Show(lista);
        }
    }
}
