using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_pizzaStore
{
    public class Pizza
    {
        public string _name;
        public string _toppings;
        public double _price;
        public string _size;
        public Pizza(string name, string toppings, string size, int price)
        {
            _name = name;
            _toppings = toppings;
            _price = price;
            _size = size;
        }

        /*public double price(int i)
        {

        }*/
        public override string ToString()
        {
            return _name.ToString() + " - Toppings: " + _toppings.ToString()
                 + " - Price: " + _price.ToString() + " - Size: " + _size.ToString();
        }
    }
}
