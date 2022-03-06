using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UML1_pizzaStore.Models
{
    public class CustomerList
    {
        public int _value;
        public CustomerList()
        {
            printCustomers();
        }
        public List<Customer> Customers()
        {
            List<Customer> customerList = new List<Customer>();

            customerList.Add(new Customer("Kate Winston", 69420069, "201 Virgin Ave.", "New York", 0));
            customerList.Add(new Customer("Mohammed Ali", 12345678, "52 Boxer Street.", "California", 3));
            customerList.Add(new Customer("Church", 13553531, "69 Devils Pier.", "Holbæk", 2));


            return customerList;
        }
        public CustomerList(int value = 0)
        {
            _value = value;
            int i = 0;
            List<Customer> customerList = Customers();
            List<int> customerOrder = new List<int>();
            foreach (Customer c in customerList)
            {
                customerOrder.Add(c._PizzaNumOrder);
            }
            Customer finder = customerList.ElementAt(value);
            int pizzaFinder = customerOrder.ElementAt(value);

            Console.WriteLine($"Customer: {finder}");


        }

        public void printCustomers()
        {
            int i = 0;
            List<Customer> customerList = Customers();
            foreach (Customer c in customerList)
            {
                Console.WriteLine(i + ": " + c);
                i++;
            }
        }
    }
}
