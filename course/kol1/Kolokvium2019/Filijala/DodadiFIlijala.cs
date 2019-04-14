using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filijala
{
    public partial class DodadiFIlijala : Form
    {
        public Filijala filijala { set; get; }
        public DodadiFIlijala()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbIme.Text == "" || tbAdresa.Text == "" || tbKratenka.Text == "") {
                MessageBox.Show("Внесете валидни податици!");
                return;
            }
            filijala = new Filijala(tbIme.Text,tbAdresa.Text,tbKratenka.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text == "")
            {
                errorProvider1.SetError(tbIme, "Името е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
                e.Cancel = false;
            }
        }

        private void tbAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (tbAdresa.Text == "")
            {
                errorProvider1.SetError(tbAdresa, "Адресата е задолжителна!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbAdresa, null);
                e.Cancel = false;
            }
        }

        private void tbKratenka_Validating(object sender, CancelEventArgs e)
        {
            if (tbKratenka.Text == "")
            {
                errorProvider1.SetError(tbKratenka, "Кратенката е задолжителна!");
                e.Cancel = true;
            }
            else {
                foreach (Char c in tbKratenka.Text) {
                    if (!Char.IsLetter(c) || !Char.IsUpper(c) || tbKratenka.Text.Length!=3) {
                        errorProvider1.SetError(tbKratenka, "Кратенката треба да биде 3 големи букви!");
                        e.Cancel = true;
                        return;
                    }
                }
                errorProvider1.SetError(tbKratenka, null);
                e.Cancel = false;
            }
            

        }
    }
}
