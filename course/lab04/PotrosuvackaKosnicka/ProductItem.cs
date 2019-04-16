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

        public override string ToString()
        {
            return String.Format("{0} - {1}x{2} = {3}" ,prod.Name,prod.Zaliha,prod.Cena,prod.Cena*prod.Zaliha);
        }
    }
}
