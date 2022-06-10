using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Emporium
{
    public class Drink : Product
    {
        public string DrinkSize { get; set; }

        

        public Drink() { }
        public Drink(string DrinkSize)
        {
            this.DrinkSize = DrinkSize;
        }

        public void SetSize (string thesize)
        {
            CalculatePrices(thesize);
        }

        public override void CalculatePrices(string thesize)
        {
            if (DrinkSize == "small")
                Price = 1.24m;
            if (DrinkSize == "medium")
                Price = 1.99m;
            if (DrinkSize == "large")
                Price = 2.50m;
        }

    }


}

 
