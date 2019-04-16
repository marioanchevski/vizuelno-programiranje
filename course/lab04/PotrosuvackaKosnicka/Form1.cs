﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbProdukti.Items.Add(new Produkt() { Name = "Mandarina", Category = "Hrana", Cena = 35.25m ,Zaliha=4});
            lbProdukti.Items.Add(new Produkt() { Name = "Tecen sapun", Category = "Higiena", Cena = 75m,Zaliha=10});
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            DodadiProdukt forma = new DodadiProdukt();
            if (forma.ShowDialog() == DialogResult.OK) {
                lbProdukti.Items.Add(forma.produkt);
            }
        }

        private void lbProdukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProdukti.SelectedIndex != -1)
            {
                Produkt p = (Produkt)lbProdukti.Items[lbProdukti.SelectedIndex];
                tbIme.Text = p.Name;
                tbCena.Text = p.Cena.ToString(".00");
                tbKategorija.Text = p.Category;
                tbZaliha.Text = p.Zaliha.ToString(".00");

            }
        }

        private void btnIsprazniP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dali ste sigurni?", "Izbrisi?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lbProdukti.Items.Clear();
                tbKategorija.Text = "";
                tbIme.Text = "";
                tbCena.Text = "";
                tbZaliha.Text = "";
            }
        }

        private void btnDelProd_Click(object sender, EventArgs e)
        {
            if (lbProdukti.SelectedIndex != -1)
            {
                lbProdukti.Items.RemoveAt(lbProdukti.SelectedIndex);
            }
        }

        private void btnIzbrisiKos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dali ste sigurni?", "Izbrisi?", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {  lbKosnicka.Items.Clear();
            tbVkupno.Text = "";
            }
        }
        public void refresh() {
            
            
        }

        public void presmetaj() {
            decimal vk = 0;
            if (lbKosnicka.Items.Count > 0) {
                foreach(ProductItem p  in lbKosnicka.Items)
                {
                    vk += p.prod.Cena;
                }
            }
            tbVkupno.Text = vk.ToString(".00");
        }

        private void btnAddKos_Click(object sender, EventArgs e)
        {
            if (lbProdukti.SelectedIndex != -1) {
                Produkt p = (Produkt)lbProdukti.Items[lbProdukti.SelectedIndex];
                if (p.Zaliha < nudKolicina.Value || nudKolicina.Value==0) {
                   // MessageBox.Show("Nema dovolno!");
                    return;
                }


                lbKosnicka.Items.Add(new ProductItem() { prod = p });
                p.Zaliha -= nudKolicina.Value;

                lbProdukti.Items[lbProdukti.SelectedIndex] = p;
               // p.Zaliha -= nudKolicina.Value;
                presmetaj();
            }
        }


       

        private void btnDelKos_Click(object sender, EventArgs e)
        {
            if (lbKosnicka.SelectedIndex != -1) {
                lbKosnicka.Items.RemoveAt(lbKosnicka.SelectedIndex);
                presmetaj();
            }
        }
    }
}
