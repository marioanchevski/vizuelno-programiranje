using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplanes
{
    public class Aerodrom
    {
        public string grad { set; get; }
        public string ime { set; get; }
        public string kratenka { set; get; }
        public List<Destinacija> destinacii { set; get; }

        public Aerodrom() {
            destinacii = new List<Destinacija>();
        }
        public Aerodrom(string gr,string im,string kr)
        {
            grad = gr;
            ime = im;
            kratenka = kr;
            destinacii = new List<Destinacija>();
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}",kratenka,ime,grad);
        }
    }
}
