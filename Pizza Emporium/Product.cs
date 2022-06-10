using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Emporium
{
    public class Product
    {
        public string description { get; set;  }
        public decimal Price { get; set; }
        public int id { get; set; }

        public Product () { }

       public Product(string theDescription, decimal thePrice, int theId)
        {
            description = theDescription;
            Price = thePrice;
            id = theId;
        }
        public virtual void CalculatePrices(string thesize)
        {

        }
    }
}
