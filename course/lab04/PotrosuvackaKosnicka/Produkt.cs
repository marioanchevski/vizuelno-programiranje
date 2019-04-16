﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosuvackaKosnicka
{
    public class Produkt
    {
        public string Name { get; set; }
        public string Category { set; get; }
        public decimal Cena { get; set; }
        public decimal Zaliha { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - dostapnost:{1}",Name,Zaliha);
        }
    }
}
