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
    public partial class DodadiAvtomobil : Form
    {
        public Avtomobil avtomobil { set; get; }
        public DodadiAvtomobil()
        {
            InitializeComponent();
        }

        public bool isValid(string str) {
            foreach (Char c in str) {
                if (!Char.IsDigit(c)){
                    return true;
                }
            }
            return false;
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            if (tbMarka.Text == "" || nudCena.Value==0 || isValid(tbJacina.Text)) {
                MessageBox.Show("Внесете валидни податоци!");
                return;
            }
            avtomobil = new Avtomobil(tbMarka.Text, nudCena.Value, Convert.ToInt32(tbJacina.Text));
            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbMarka_Validating(object sender, CancelEventArgs e)
        {
            if (tbMarka.Text == "")
            {
                errorProvider1.SetError(tbMarka, "Марката е задолжителна!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbMarka, null);
                e.Cancel = false;
            }
        }

        private void nudCena_Validating(object sender, CancelEventArgs e)
        {
            if (nudCena.Value == 0)
            {
                errorProvider1.SetError(nudCena, "Цената неможе да биде 0");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudCena, null);
                e.Cancel = false;
            }
        }

        private void tbJacina_Validating(object sender, CancelEventArgs e)
        {
            int k;
            if (int.TryParse(tbJacina.Text, out k) && k < 40)
            {
                errorProvider1.SetError(tbJacina, "Минимум 40");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbJacina, null);
                e.Cancel = false;
            }
        }
    }
}
