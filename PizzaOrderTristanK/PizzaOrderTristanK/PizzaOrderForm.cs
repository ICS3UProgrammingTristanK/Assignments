/*
 * Created By: Tristan Kalabric
 * Created On: October 22, 2018
 * Created For: ISC3U Programming
 * Major Assignment #5 - Pizza Order
 * This Assignment simulates a pizza parlours order menu and lets the user pick the size of pizza they want, the number of pizzas, the number of toppings, and if they want a drink
 * when they are done choosing what they want the subtotal, tax, and total will be displayed.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderTristanK
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblXLarge_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare local variables
            double subtotal, total, pizzaSize, pizzaNumber, drink, toppings, tax;

            //Declare constants\
            const double MEDIUM = 4.99;
            const double LARGE = 9.99;
            const double XLARGE = 12.99;
            const double YES = 0.50;
            const double NO = 0.00;
            const double TAX = 0.13;

            //Check the nud for pizza size
            if (nudPizzaSize.Value == 1)
            {
                //Set pizzaSize value
                pizzaSize = MEDIUM;
            }
            else if (nudPizzaSize.Value == 2)
            {
                //Set pizzaSize value
                pizzaSize = LARGE;
            }
            else
            {
                //Set pizzaSize value
                pizzaSize = XLARGE;
            }

            //Check the nud for the number of pizza's
            if (nudPizzaNumber.Value == 1)
            {
                //Set pizzaNumber value
                pizzaNumber = 1;
            }
            else
            {
                //Set pizzaNumber value
                pizzaNumber = 2;
            }

            //Check nud for the number of toppings
            if (nudToppingsNumber.Value == 1)
            {
                //Set toppings value
                toppings = 0.75;
            }
            else if (nudToppingsNumber.Value == 2)
            {
                //Set toppings value
                toppings = 1.35;
            }
            else if (nudToppingsNumber.Value == 3)
            {
                //Set toppings value
                toppings = 2.15;
            }
            else
            {
                //Set toppings value
                toppings = 2.75;
            }

            //Check nud for drink
            if (nudDrink.Value == 1)
            {
                //Set the drink value
                drink = YES;
            }
            else
            {
                //Set the drink value
                drink = NO;
            }

            //Calculate the subtotal
            if (pizzaSize == MEDIUM)
            {
                if (pizzaNumber == 1)
                {
                    //Add 0 to the subtotal and the price for the pizza
                    subtotal = MEDIUM * pizzaNumber;
                }
                else
                {
                    //Add the price of the pizza twice to the subtotal
                    subtotal = MEDIUM * pizzaNumber;
                }
                if (toppings == 0.75)
                {
                    //Add the toppings price to the subtotal
                    subtotal = MEDIUM * pizzaNumber + toppings;
                }
                else if (toppings == 1.35)
                {
                    //Add the toppings price to the subtotal
                    subtotal = MEDIUM * pizzaNumber + toppings;
                }
                else if (toppings == 2.15)
                {
                    //Add the toppings price to the subtotal
                    subtotal = MEDIUM * pizzaNumber + toppings;
                }
                else
                {
                    //Add the toppings price to the subtotal
                    subtotal = MEDIUM * pizzaNumber + toppings;
                }
                if (drink == YES)
                {
                    //Add 0.50 to the subtotal
                    subtotal = MEDIUM * pizzaNumber + toppings + drink;
                }
                else
                {
                    //Dont add anythink to the subtotal
                    subtotal = MEDIUM * pizzaNumber + toppings;
                }
                //Calculate and display the subtotal, total, and tax
                {
                    this.lblSubtotal.Text = "Subtotal: " + subtotal;
                    tax = subtotal * TAX;
                    this.lblTax.Text = "Tax: " + tax;
                    total = subtotal + tax;
                    this.lblTotal.Text = "Total: " + total;
                }
            }

            //Calculate the subtotal
            else if (pizzaSize == LARGE)
            {
                if (pizzaNumber == 1)
                {
                    //Add 0 to the subtotal and the price for the pizza
                    subtotal = LARGE * pizzaNumber;
                }
                else
                {
                    //Add the price of the pizza twice to the subtotal
                    subtotal = LARGE * pizzaNumber;
                }
                if (toppings == 0.75)
                {
                    //Add the toppings price to the subtotal
                    subtotal = LARGE * pizzaNumber + toppings;
                }
                else if (toppings == 1.35)
                {
                    //Add the toppings price to the subtotal
                    subtotal = LARGE * pizzaNumber + toppings;
                }
                else if (toppings == 2.15)
                {
                    //Add the toppings price to the subtotal
                    subtotal = LARGE * pizzaNumber + toppings;
                }
                else
                {
                    //Add the toppings price to the subtotal
                    subtotal = LARGE * pizzaNumber + toppings;
                }
                if (drink == YES)
                {
                    //Add 0.50 to the subtotal
                    subtotal = LARGE * pizzaNumber + toppings + drink;
                }
                else
                {
                    //Dont add anythink to the subtotal
                    subtotal = LARGE * pizzaNumber + toppings;
                }
                //Calculate and display the subtotal, total, and tax
                {
                    this.lblSubtotal.Text = "Subtotal: " + subtotal;
                    tax = subtotal * TAX;
                    this.lblTax.Text = "Tax: " + tax;
                    total = subtotal + tax;
                    this.lblTotal.Text = "Total: " + total;
                }
            }
            //Calculate the subtotal
            else if (pizzaSize == XLARGE)
            {
                if (pizzaNumber == 1)
                {
                    //Add 0 to the subtotal and the price for the pizza
                    subtotal = XLARGE * pizzaNumber;
                }
                else
                {
                    //Add the price of the pizza twice to the subtotal
                    subtotal = XLARGE * pizzaNumber;
                }
                if (toppings == 0.75)
                {
                    //Add the toppings price to the subtotal
                    subtotal = XLARGE * pizzaNumber + toppings;
                }
                else if (toppings == 1.35)
                {
                    //Add the toppings price to the subtotal
                    subtotal = XLARGE * pizzaNumber + toppings;
                }
                else if (toppings == 2.15)
                {
                    //Add the toppings price to the subtotal
                    subtotal = XLARGE * pizzaNumber + toppings;
                }
                else
                {
                    //Add the toppings price to the subtotal
                    subtotal = XLARGE * pizzaNumber + toppings;
                }
                if (drink == YES)
                {
                    //Add 0.50 to the subtotal
                    subtotal = XLARGE * pizzaNumber + toppings + drink;
                }
                else
                {
                    //Dont add anythink to the subtotal
                    subtotal = XLARGE * pizzaNumber + toppings;
                }
                //Calculate and display the subtotal, total, and tax
                {
                    this.lblSubtotal.Text = "Subtotal: " + subtotal;
                    tax = subtotal * TAX;
                    this.lblTax.Text = "Tax: " + tax;
                    total = subtotal + tax;
                    this.lblTotal.Text = "Total: " + total;
                }
            }
        }
    }
}
            