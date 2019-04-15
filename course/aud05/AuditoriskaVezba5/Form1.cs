using System;
using System.Windows.Forms;

namespace AuditoriskaVezba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbTimovi.Items.Add(new Team("Real Madrid", "Spain"));
            lbTimovi.Items.Add(new Team("Milan", "Italy"));
            lbTimovi.Items.Add(new Team("Barcelona", "Spain"));
            lbTimovi.Items.Add(new Team("Vardar", "Macedonia"));

        }

        private void btnDodadiT_Click(object sender, EventArgs e)
        {
            DodadiTim f2 = new DodadiTim();
            DialogResult res = f2.ShowDialog();
            if (res == DialogResult.OK) {
                lbTimovi.Items.Add(f2.tim);
            }
        }

        private void btnDodadiB_Click(object sender, EventArgs e)
        {
            

            if (lbTimovi.SelectedItems.Count == 2) {

                if (mtbSifra.Text == "") {
                    MessageBox.Show("Sifrata e zadolzitelna!");
                    return;
                }

                string sifra = mtbSifra.Text;
                foreach (Game game1 in lbBilten.Items)
                {
                    if (sifra == game1.sifra)
                    {
                        MessageBox.Show("sifrata veke postoi");
                        return;
                    }
                }
                Game game = new Game();
                game.doma = (Team)lbTimovi.SelectedItems[0];
                game.gosti= (Team)lbTimovi.SelectedItems[1];
                game.sifra = mtbSifra.Text;
                game.koeficienti[0] = nud1.Value;
                game.koeficienti[1] = nudX.Value;
                game.koeficienti[2] = nud2.Value;
                lbBilten.Items.Add(game);
                lbTimovi.SelectedItems.Clear();

            }
            else {
                MessageBox.Show("Izberete tocno 2 tima!");
            }
        }

        private void btnDodadiN_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            Game temp = null;
            if (cbTip.SelectedIndex == -1) {
                MessageBox.Show("Izberi validen tip!");
                return;
            }
            if (tbSifra.Text != "")
            {
                foreach (Game game in lbBilten.Items)
                {
                    if (tbSifra.Text == game.sifra)
                    {
                        temp = game;
                    }
                }
                ticket.igra = temp;
                ticket.tip = cbTip.SelectedIndex;
                lbTiket.Items.Add(ticket);
                lbBilten.SelectedItems.Clear();
            }
            else if (lbBilten.SelectedItems.Count == 1)
            {
                ticket.igra = (Game)lbBilten.SelectedItem;
                ticket.tip = cbTip.SelectedIndex;
                lbTiket.Items.Add(ticket);
                lbBilten.SelectedItems.Clear();
            }
            else {
                MessageBox.Show("Izberi  !");
            }
            presmetaj();

        }
        void presmetaj() {
            decimal total = 1;
            
            foreach (Ticket t in lbTiket.Items) {
                Game g = t.igra;
                total *= g.koeficienti[t.tip];
            }
            tbVkupno.Text = total.ToString(".00");
            tbDobivka.Text = (total * nudUplata.Value).ToString(".00");

        }

        private void nudUplata_KeyUp(object sender, KeyEventArgs e)
        {
            presmetaj();
        }

        private void nudUplata_ValueChanged(object sender, EventArgs e)
        {
            presmetaj();
        }
    }
}
