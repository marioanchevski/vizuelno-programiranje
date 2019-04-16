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
                errorProvider1.SetError(tbIme, "Името е задолжително!");
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
                errorProvider1.SetError(tbKategorija, "Категоријата е задолжителна!");
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
                errorProvider1.SetError(tbCena, "Цената е задолжителна!");
                e.Cancel = true;
            }
            if (!decimal.TryParse(tbCena.Text,out d)) {
                errorProvider1.SetError(tbCena, "Внесете валидна вредност!");
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
                MessageBox.Show("Сите полиња се задолжителни!");
                return;
            }

            produkt = new Produkt() { Cena=Convert.ToDecimal(tbCena.Text), Name=tbIme.Text,Category=tbKategorija.Text,Zaliha=Convert.ToInt32(nudZaliha.Value)};
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
                errorProvider1.SetError(nudZaliha, "Залихата мора да е минимум 1");
                e.Cancel = true;

            }
            else {
                errorProvider1.SetError(nudZaliha, null);
                e.Cancel = false;
            }
        }
    }
}
