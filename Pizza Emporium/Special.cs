using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Emporium
{
    public class Special : Product
    {
        public string SpecialSize { get; set; }
        public Special() { }

        public Special (string specialSize)
        {
            this.SpecialSize = specialSize;
        }

        public void setSize(string theSize)
        {
            CalculatePrices(theSize);
        }

        public override void CalculatePrices(string thesize)
        {
            if (SpecialSize == "small")
                Price = 8.00m;
            if (SpecialSize == "medium")
                Price = 10.99m;
        
        }
    }
}
