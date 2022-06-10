using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Emporium
{
    public partial class frmPizzaEmporium : Form
    {
        public frmPizzaEmporium()
        {
            InitializeComponent();
        }

        string pizzaSize = "";
        string drinkSize = "";
        string saladSize = "";
        string specialSize = "";
        string coolSize = "";

        Product currentProduct = null;
  

      
        private void btnPizza_Click(object sender, EventArgs e)
        {
            
            grpPizza.Visible = true;

            grpDrinks.Visible = false;
            grpCoolStuff.Visible = false;
            grpSalads.Visible = false;
            grpSpecials.Visible = false;
            currentProduct = new Pizza();


        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {


            grpDrinks.Visible = true;
            grpPizza.Visible = false;

            grpCoolStuff.Visible = false;
            grpSalads.Visible = false;
            grpSpecials.Visible = false;
            currentProduct = new Drink();

            



        }


        private void btnSalads_Click(object sender, EventArgs e)
        {

            grpSalads.Visible = true;
            grpPizza.Visible = false;
            grpDrinks.Visible = false;
            grpCoolStuff.Visible = false;

            grpSpecials.Visible = false;
            currentProduct = new Salad();
        }


        private void btnSpecials_Click(object sender, EventArgs e)
        {

            grpSpecials.Visible = true;
            grpPizza.Visible = false;
            grpDrinks.Visible = false;
            grpCoolStuff.Visible = false;
            grpSalads.Visible = false;

            currentProduct = new Special();
        }

        private void btnCoolStuff_Click(object sender, EventArgs e)
        {

            grpCoolStuff.Visible = true;
            grpPizza.Visible = false;
            grpDrinks.Visible = false;

            grpSalads.Visible = false;
            grpSpecials.Visible = false;

            currentProduct = new Promotional();

        }

        private void frmPizzaEmporium_Load(object sender, EventArgs e)
        {
            grpPizza.Visible = false;
            grpDrinks.Visible = false;
            grpCoolStuff.Visible = false;
            grpSalads.Visible = false;
            grpSpecials.Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rdoSmallPizza.Checked)
            {

                pizzaSize = "small";
                if (chkCheese.Checked)
                {
                    
                }
            }
            if (rdoMediumPizza.Checked)
            {
                pizzaSize = "medium";

            }
            if(rdoLargePizza.Checked)
            {
                pizzaSize = "large";
            }
            if (rdoSmallDrink.Checked)
                drinkSize = "small";
            if (rdoMediumDrink.Checked)
                drinkSize = "medium";
            if (rdoLargeDrink.Checked)
                drinkSize = "large";
            if (rdoHalfSalad.Checked)
                saladSize = "half";
            if (rdoFullSalad.Checked)
                saladSize = "full";
            if (rdoSpecial1.Checked)
                specialSize = "small";
           
            if (rdoSpecial2.Checked)
                specialSize = "medium";
            if (rdoSmallSpecial.Checked)
                coolSize = "small";
            if (rdoMedSpecial.Checked)
                coolSize = "medium";
            if (rdoLargeSpecial.Checked)
                coolSize = "large";
            currentProduct.CalculatePrices(pizzaSize);
            currentProduct.CalculatePrices(drinkSize);
            currentProduct.CalculatePrices(saladSize);
            currentProduct.CalculatePrices(specialSize);
            currentProduct.CalculatePrices(coolSize);
            InvoiceItem theItem = new InvoiceItem(currentProduct, 1);
            //CurrentOrder.AddItem(theItem);
            lstOrders.Items.Add(theItem.ToString());
        }

      
    }

}
    

