using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Igrac
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Igrac(string n, int p) {
            Name = n;
            Points = p;
        }
    }
}
