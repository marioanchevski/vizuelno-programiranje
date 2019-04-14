using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filijala
{
    public class Avtomobil
    {
        public string marka { set; get; }
        public decimal cena { set; get; }
        public int jacina { set; get; }
        public bool rezerviran { set; get; }

        public Avtomobil(string marka,decimal cena,int jacina) {
            this.marka = marka;
            this.cena = cena;
            this.jacina = jacina;
            rezerviran = false;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}",marka,cena,rezerviran ? "Резервиран" : "Достапен");
        }
    }
}
