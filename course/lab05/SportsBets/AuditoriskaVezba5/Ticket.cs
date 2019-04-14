using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditoriskaVezba5
{
    class Ticket
    {
        public Game igra { set; get; }
        public int tip { set; get; }


        public override string ToString()
        {
            return String.Format("{0} vs {1} : {2}",igra.doma.ime,igra.gosti.ime, tip == 0 ? "1" : tip == 1 ? "X" : "2");
        }

    }
}
