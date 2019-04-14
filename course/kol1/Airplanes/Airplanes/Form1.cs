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
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            lbAerodromi.Items.Add(new Aerodrom("Skopje", "Aleksandar Veliki", "SKP"));
            lbAerodromi.Items.Add(new Aerodrom("Viena", "Viena IA", "VIE"));

        }

            public List<Object> get() {
            List<Object> lista = new List<Object>();
            foreach (Object obj in lbAerodromi.Items) {
                lista.Add(obj);
            }
            return lista;
            }

        private void btnDodadiA_Click(object sender, EventArgs e)
        {
            DodadiAerodro f1 = new DodadiAerodro();
            DialogResult res = f1.ShowDialog();
            if (res == DialogResult.OK) {
                foreach (Aerodrom ar in lbAerodromi.Items) {
                    if (ar.kratenka == f1.aerodrom.kratenka) {
                        MessageBox.Show("Aerodrom so takva kratenka veke postoi!");
                        return;
                    }
                }
                lbAerodromi.Items.Add(f1.aerodrom);
            }
        }

        private void btnIzbrisiA_Click(object sender, EventArgs e)
        {
            if (lbAerodromi.SelectedIndex != -1)
            {
                DialogResult res = MessageBox.Show("Dali ste sigurni", "Poraka nekoja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes) { 
                lbAerodromi.Items.Remove(lbAerodromi.SelectedItem);
                refresh();
                }
            }
        }
        public void refresh() {
            lbDestinacii.Items.Clear();
            tbNajskapa.Text = "";
            tbProsecna.Text = "";
            if (lbAerodromi.SelectedIndex != -1) {
                
                
                    Aerodrom aer = (Aerodrom)lbAerodromi.Items[lbAerodromi.SelectedIndex];
                if (aer.destinacii.Count > 0) { 
                    Destinacija max = aer.destinacii[0];
                    decimal vk = 0;
                    foreach (Destinacija d in aer.destinacii)
                    {
                        lbDestinacii.Items.Add(d);
                        if (d.cena > max.cena) max = d;
                        vk += d.km;
                    }
                    tbNajskapa.Text = max.ToString();
                    tbProsecna.Text = (vk / aer.destinacii.Count()).ToString(".00");
                }



            }
        }

        private void btnDodadiD_Click(object sender, EventArgs e)
        {
            if (lbAerodromi.SelectedIndex != -1)
            {
                addDest form = new addDest();
                Aerodrom aer = (Aerodrom)lbAerodromi.Items[lbAerodromi.SelectedIndex];
                if (form.ShowDialog() == DialogResult.OK)
                {
                    aer.destinacii.Add(form.dest);
                    refresh();
                }
            }
            else {
                MessageBox.Show("Izberete aerodrom od ponudenata lista!");
            }
        }

        private void lbAerodromi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIzbrisiA.Enabled = lbAerodromi.SelectedIndex != -1;
            btnDodadiD.Enabled = lbAerodromi.SelectedIndex != -1;
            refresh();
        }
    }
}
