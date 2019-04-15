using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Desert
    {

        public String ime { set; get; }
        public int cena { set; get; }

        public Desert() { }

        public Desert(String i, int c) {
            ime = i;
            cena = c;
        }

        public override string ToString()
        {
            return String.Format("{0}-{1}",ime,cena);
        }
    }
}
