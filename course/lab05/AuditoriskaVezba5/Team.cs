using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditoriskaVezba5
{
    public class Team
    {
        public string ime { set; get; }
        public string drzava { set; get; }

        public Team() { }
        public Team(string i,string d) {
            ime = i;
            drzava = d;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}",ime,drzava);
        }


    }
}
