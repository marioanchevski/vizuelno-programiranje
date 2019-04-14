using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplanes
{
   public class Destinacija
    {
        public string ime { get; set; }
        public decimal km { get; set; }
        public decimal cena { set; get; }

        public Destinacija() { }
        public Destinacija(string i,decimal k,decimal c) {
            ime = i;
            km = k;
            cena = c;
        }
        public override string ToString()
        {
            return String.Format("{0}\t{1}km - {2} EUR",ime,km,cena);
        }
    }
}
