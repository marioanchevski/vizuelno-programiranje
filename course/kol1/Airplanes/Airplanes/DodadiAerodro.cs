using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airplanes
{
    public partial class DodadiAerodro : Form
    {
        public Aerodrom aerodrom;
        public DodadiAerodro()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            
            foreach (Aerodrom ar in f1.get()) {
                if (ar.kratenka == tbKratenka.Text) {
                    MessageBox.Show("Kratenkata veke postoi");
                    return;
                }

            }
            if (tbKratenka.Text == "") {
                MessageBox.Show("Site polinja se zadolzitelni!");
                return;
            }


            aerodrom = new Aerodrom();
            aerodrom.grad = tbGrad.Text;
            aerodrom.ime = tbIme.Text;
            aerodrom.kratenka = tbKratenka.Text;
            DialogResult = DialogResult.OK;

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbGrad_Validating(object sender, CancelEventArgs e)
        {
            if (tbGrad.Text == "")
            {
                errorProvider1.SetError(tbGrad, "Poleto e zadolzitelno!");
                e.Cancel = true;
            }
            else {
                errorProvider1.SetError(tbGrad, null);
                e.Cancel = false;
            }
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text == "")
            {
                errorProvider1.SetError(tbIme, "Poleto e zadolzitelno!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
                e.Cancel = false;
            }
        }

        int check(char[] arr) {
            int k = 0;
            foreach (char c in arr) {
                if (!Char.IsLetter(c) || !Char.IsUpper(c) || arr.Length!=3)
                {
                    k++;
                }
            }
            return k;
        } 

        private void tbKratenka_Validating(object sender, CancelEventArgs e)
        {
            /*         char[] str = tbKratenka.Text.ToCharArray();
                     if (tbKratenka.Text == "")
                     {
                         errorProvider1.SetError(tbKratenka, "poleto e zadolzitelno");
                         e.Cancel = true;
                     }
                     else if (check(str) != 0)
                     {
                         errorProvider1.SetError(tbKratenka, "mora da sodrzi tocno 3 golemi bukvi");
                         e.Cancel = true;
                     }
                     else {
                         errorProvider1.SetError(tbKratenka, null);
                         e.Cancel = false;
                     }
                     */
            if (tbKratenka.Text == "") {
                errorProvider1.SetError(tbKratenka, "poleto e zadolzitelno");
                e.Cancel = true;
                return;
            }

            foreach(Char c in tbKratenka.Text)
            {
                if (Char.IsDigit(c) || !Char.IsUpper(c) || !Char.IsLetter(c)) {
                    errorProvider1.SetError(tbKratenka, "3 golemi bukvi");
                    e.Cancel = true;
                    return;
                }
            }
            errorProvider1.SetError(tbKratenka, null);
            e.Cancel = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
