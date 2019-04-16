using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosuvackaKosnicka
{
    public class ProductItem
    {
        public Produkt prod { get; set; }
        public int kolicina { set; get; }

        public override string ToString()
        {
            return String.Format("{0} - {1}x{2} = {3}" ,prod.Name,kolicina,prod.Cena,prod.Cena*kolicina);
        }
    }
}
