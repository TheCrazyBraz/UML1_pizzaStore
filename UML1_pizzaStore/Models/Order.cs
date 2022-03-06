using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_pizzaStore.Models
{
    public class Order
    {

        public Order(int value = 0)
        {   
            
            //Print Menu
          //  Menu menu = new Menu("Start");

            //Print Customers
           // CustomerList betaList = new CustomerList();



            CustomerList c = new CustomerList(value);
            Menu priceC1 = new Menu("Payment", c._value);




            /*Console.WriteLine("\n Please select what pizza you want (By number)");
            string pizzeNumberChosen = Console.ReadLine();
            try
            {
                int numberParse = Int32.Parse(pizzeNumberChosen);


                Console.WriteLine("You have chossen Pizza number: " + numberParse + " - The price will be:");
                Menu price = new Menu("Payment", numberParse);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{pizzeNumberChosen}'");
            } */


        }

    }
}
