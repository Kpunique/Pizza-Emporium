using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Emporium
{
    class Promotional : Product
    {
        public string coolSize { get; set; }


        public Promotional() { }
        public Promotional(string coolSize)
        {
            this.coolSize = coolSize;
        }

        public void setSize (string theSize)
        {
            CalculatePrices(theSize);
        }

        public override void CalculatePrices(string thesize)
        {
            if (coolSize == "small")
                Price = 8.00m;
            if (coolSize == "medium")
                Price = 12.00m;
            if (coolSize == "large")
                Price = 17.50m;
        }

    }
}
