using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditoriskaVezba5
{
    public partial class DodadiTim : Form
    {
        public Team tim;
        public DodadiTim()
        {
            InitializeComponent();
        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            tim = new Team();
            tim.ime = tbIme.Text;
            tim.drzava = tbDrzava.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
