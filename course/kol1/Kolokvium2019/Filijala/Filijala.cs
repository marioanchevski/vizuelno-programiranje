using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filijala
{
    public class Filijala
    {
        public string ime { set; get; }
        public string adresa { set; get; }
        public string kod { set; get; }
        public List<Avtomobil> avto { set; get; }


        public Filijala(string ime,string adresa,string kod) {
            this.ime = ime;
            this.adresa = adresa;
            this.kod = kod;
            avto = new List<Avtomobil>();
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}",kod,ime,adresa);
        }
    }
}
