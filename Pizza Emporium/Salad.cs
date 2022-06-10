using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Emporium
{
    public class Salad : Product
    {
        public string SaladSize { get; set; }


        public Salad() { }
        public Salad(string SaladSize)
        {
            this.SaladSize = SaladSize;
        }

        public void setSize(string theSize)
        {
            CalculatePrices(theSize);
        }

        public override void CalculatePrices(string thesize)
        {
            if (SaladSize == "half")
                Price = 7.00m;
            if (SaladSize == "full")
                Price = 9.99m;


        }
    }
}
