using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Emporium
{
    class InvoiceItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public InvoiceItem() { }
        public InvoiceItem(Product aProduct, int theQuantity)
        {
            Product = aProduct;
            Quantity = theQuantity;
        }
          
    }
}
