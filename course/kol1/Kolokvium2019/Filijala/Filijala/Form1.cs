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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbFilijali.Items.Add(new Filijala("Filijala1", "Skopje", "SKP"));
            lbFilijali.Items.Add(new Filijala("Filijala2", "Probistip", "PS"));
        }

        private void btnAddF_Click(object sender, EventArgs e)
        {
            DodadiFIlijala forma = new DodadiFIlijala();
            if (forma.ShowDialog() == DialogResult.OK) {
                lbFilijali.Items.Add(forma.filijala);
            }
        }

        private void btnDelF_Click(object sender, EventArgs e)
        {
            if (lbFilijali.SelectedIndex != -1) {
                if (MessageBox.Show("Дали сте сигурни?","Избриши филијала",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
                    lbFilijali.Items.RemoveAt(lbFilijali.SelectedIndex);
                }
            }
        }

        public void prikazi() {
            lbAvtomobili.Items.Clear();
            tbCena.Text = "";

            if (lbFilijali.SelectedIndex != -1) {
                Filijala fil = (Filijala)lbFilijali.Items[lbFilijali.SelectedIndex];
                foreach (Avtomobil a in fil.avto) {
                    lbAvtomobili.Items.Add(a);
                }

                if (fil.avto.Count > 0)
                {
                    decimal vk = 0;
                    foreach (Avtomobil a in fil.avto)
                    {
                        if (a.rezerviran)
                        {
                            vk += a.cena;
                        }
                    }
                    tbCena.Text = vk.ToString(".00");
                }

            }
        }

        private void btnAddA_Click(object sender, EventArgs e)
        {
            if (lbFilijali.SelectedIndex != -1) {
                Filijala fil = (Filijala)lbFilijali.Items[lbFilijali.SelectedIndex];
                DodadiAvtomobil forma = new DodadiAvtomobil();
                if (forma.ShowDialog() == DialogResult.OK) {
                    fil.avto.Add(forma.avtomobil);
                    prikazi();
                }
            }
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            if (lbAvtomobili.SelectedIndex != -1) {
                Avtomobil avto = (Avtomobil)lbAvtomobili.Items[lbAvtomobili.SelectedIndex];
                avto.rezerviran = true;
                prikazi();
            }
        }

        private void lbFilijali_SelectedIndexChanged(object sender, EventArgs e)
        {
            prikazi();
        }

        private void btnPrebaraj_Click(object sender, EventArgs e)
        {
            Filijala fil = null;
            Avtomobil avt = null;
            if (lbFilijali.Items.Count>0) {
                foreach (Filijala f in lbFilijali.Items) {
                    if (f.avto.Count > 0) {
                        Avtomobil max = f.avto[0];
                        foreach (Avtomobil a in f.avto) {
                            if (a.cena <= max.cena) {
                                fil = f;
                                avt = a;
                            }
                        }
                    }
                }
            }
            if (fil != null && avt != null) {
                MessageBox.Show(String.Format("Најевтин автомобил: {0}\nОд Филијала: {1}",avt,fil));
            }
        }
    }
}
