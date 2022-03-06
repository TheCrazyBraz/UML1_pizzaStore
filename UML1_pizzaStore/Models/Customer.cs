using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_pizzaStore.Models
{
    public class Customer
    {
        public string _name;
        public string _adress;
        public int _phonenumber;
        public string _city;
        public int _PizzaNumOrder;
        public Customer(string name = "null", int phonenumber = 0, string adress = "null", string city = "null", int PizzaNumOrder = 0)
        {
            _name = name;
            _phonenumber = phonenumber;
            _adress = adress;
            _city = city;

            _PizzaNumOrder = PizzaNumOrder;
        }


        public override string ToString()
        {
            return _name.ToString() + " - Phone Number: " + _phonenumber.ToString()
                 + " - Adress: " + _adress.ToString() + " - City: " + _city.ToString() + " - Ordered pizza number: " + _PizzaNumOrder.ToString();
        }
    }
}
        
