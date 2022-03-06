using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UML1_pizzaStore.Models
{
    public class Menu
    {
        public int delivery = 40;
        public double taxes = 1.25;
        public List<Pizza> theMenu()
        {
            List<Pizza> pizzaMenu = new List<Pizza>();

            pizzaMenu.Add(new Pizza("Margarita", "Tomato and cheese", "Normal", 49));
            pizzaMenu.Add(new Pizza("Margarita", "Tomato and cheese", "Family", 119));
            pizzaMenu.Add(new Pizza("Hawaii", "Tomato, cheese, ham and Pineapple", "Normal", 54));
            pizzaMenu.Add(new Pizza("Hawaii", "Tomato, cheese, ham and Pineapple", "Family", 124));

            return pizzaMenu;
        }
        public void printMenu()
        {
            int i = 0;
            List<Pizza> pizzaMenu = theMenu();
            foreach (Pizza p in pizzaMenu)
            {
                Console.WriteLine(i +": " + p);
                i++;
            }
        }

        public void Prices(int value)
        {
            int i = 0;
            List<Pizza> pizzaMenu = theMenu();
            List<double> prices = new List<double>();
            foreach (Pizza p in pizzaMenu)
            {p._price = p._price + delivery * taxes; //Shipping og Taxes
                prices.Add(p._price);
            }
            /* // Tester, to see prices
             foreach (double p in prices)
            {
                Console.WriteLine(i + ": " + p);
                i++;
            }*/
            double finder = prices.ElementAt(value);
            Console.WriteLine("Total: " + finder);

        }

        public Menu(string toDo, int value)
        {
            if (toDo == "Start")
            {
                printMenu();
            }
            else if(toDo == "Payment")
            {
                Prices(value);

            }
        }

    }
}
