using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotrosuvackaKosnicka
{
    public partial class DodadiProdukt : Form
    {
        public Produkt produkt { get; set; }
        public DodadiProdukt()
        {
            InitializeComponent();
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text == "")
            {
                errorProvider1.SetError(tbIme, "Imeto ne smee da e prazo!");
                e.Cancel = true;
            }
            else {
                errorProvider1.SetError(tbIme, null);
                e.Cancel = false;
            }
        }

        private void tbKategorija_Validating(object sender, CancelEventArgs e)
        {
            if (tbKategorija.Text == "")
            {
                errorProvider1.SetError(tbKategorija, "Kategorijata ne smee da e praza!");
                e.Cancel = true;
            }
            else {
                errorProvider1.SetError(tbKategorija, null);
                e.Cancel = false;
            }
        }

        private void tbCena_Validating(object sender, CancelEventArgs e)
        {
            decimal d;
            if (tbCena.Text == "")
            {
                errorProvider1.SetError(tbCena, "Cenata ne smee da e prazna!");
                e.Cancel = true;
            }
            if (!decimal.TryParse(tbCena.Text,out d)) {
                errorProvider1.SetError(tbCena, "Vnesete validna vrednost!");
                e.Cancel = true;
         
            }
            else {
               
                errorProvider1.SetError(tbCena, null);
                e.Cancel = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCena.Text == "" || tbIme.Text == "" || tbKategorija.Text == "") {
                MessageBox.Show("Site polinja se zadolzitelni!");
                return;
            }

            produkt = new Produkt() { Cena=Convert.ToDecimal(tbCena.Text), Name=tbIme.Text,Category=tbKategorija.Text,Zaliha=nudZaliha.Value};
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void nudZaliha_Validating(object sender, CancelEventArgs e)
        {
            if (nudZaliha.Value == 0)
            {
                errorProvider1.SetError(nudZaliha, "poveke od 1 ");
                e.Cancel = true;

            }
            else {
                errorProvider1.SetError(nudZaliha, null);
                e.Cancel = false;
            }
        }
    }
}
