using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditoriskaVezba5
{
    class Game
    {
        public string sifra { set; get; }
        public Team doma { set; get; }
        public Team gosti { set; get; }
        public decimal[] koeficienti { set; get; }

        public Game() {
            koeficienti = new decimal[3];
        }

        public override string ToString()
        {
            return String.Format("{0}---{1} vs {2}",sifra,doma.ime,gosti.ime);
        }

    }
}
