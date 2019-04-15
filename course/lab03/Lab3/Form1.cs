using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       


        public void presmetaj() {
            int cena = 0;
            int malaPica, srednaPica, golemaPica;


            int.TryParse(tbMala.Text, out malaPica);
            int.TryParse(tbSredna.Text, out srednaPica);
            int.TryParse(tbGolema.Text, out golemaPica);
            if (rbMala.Checked)
            {
                cena += malaPica;
            }
            if (rbSredna.Checked)
            {
                cena += srednaPica;
            }
            if (rbGolema.Checked)
            {
                cena += golemaPica;
            }

            
            int fe, sirenje, kecap;
            int.TryParse(tbFeferoni.Text, out fe);
            int.TryParse(tbSirenje.Text, out sirenje);
            int.TryParse(tbKecap.Text, out kecap);


            if (cbFeferoni.Checked)
            {
                cena += fe;
            }
            if (cbSirenje.Checked)
            {
                cena += sirenje;
            }
            if (cbKecap.Checked)
            {
                cena += kecap;
            }



            int gazirano = 0;
            if (int.TryParse(tbGaziran.Text, out gazirano))
            {
                gazirano = Convert.ToInt32(tbGaziran.Text) * Convert.ToInt32(tbCenaG.Text);
            }
            int sok1 = 0;
            if (int.TryParse(tbSok.Text, out sok1)) {
                sok1 = Convert.ToInt32(tbSok.Text) * Convert.ToInt32(tbCenaSok.Text);
            }
            int pivo1 = 0;
            if (int.TryParse(tbPivo.Text, out pivo1)) {
                pivo1 = Convert.ToInt32(tbPivo.Text) * Convert.ToInt32(tbCenaPivo.Text);
            }

                tbVkupnoG.Text = gazirano.ToString();
                tbVkupnoSok.Text = sok1.ToString();
                tbVkupnoPivo.Text = pivo1.ToString();
                cena += gazirano;
                cena += sok1;
                cena += pivo1;

         
            foreach (Desert d in lbDeserti.Items) {
                cena += d.cena;
            }
            tbVkupno.Text = cena.ToString();


            int naplateno = 0;
            int z = 0;
            if (int.TryParse(tbNaplateno.Text, out naplateno))
            {
                z = naplateno - cena;
            }
            tbZaVrakanje.Text = z.ToString();

        }

 
        private void rbMala_CheckedChanged_1(object sender, EventArgs e)
        {
            presmetaj();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            if (tbDesertIme.Text != "" && tbDesertCena.Text!="") {
                Desert d = new Desert();
                d.ime = tbDesertIme.Text;
                d.cena = Convert.ToInt32(tbDesertCena.Text);
                lbDeserti.Items.Add(d);
                tbDesertCena.Text = "";
                tbDesertIme.Text = "";
                presmetaj();
            }
        }

        private void btnNaracaj_Click(object sender, EventArgs e)
        {
            if (lbDeserti.SelectedIndex != -1) {
                lbDeserti.Items.RemoveAt(lbDeserti.SelectedIndex);
                presmetaj();
            }
        }

    }
}
