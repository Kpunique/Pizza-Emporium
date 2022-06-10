using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Emporium
{
    public class Pizza : Product
    {
        private string pizzaSize { get; set; }

        public ListBox lstOrder { get; set; }
        


        public Pizza () { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pizzaSize"></param>
        public Pizza(string pizzaSize)
        {
            this.pizzaSize = pizzaSize;
        }

        public void SetSize(string thesize)
        {
            CalculatePrices(thesize);
        }

       

        public override void CalculatePrices(string pizzaSize)
        {
            if (pizzaSize == "small")
                Price = 5.25m;
            else if (pizzaSize == "medium")
                Price = 10.50m;
            else if (pizzaSize == "large")
                Price = 15.50m;

        }
       

    }
}
