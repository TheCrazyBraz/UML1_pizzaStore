using System;

namespace UML1_pizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {

            Models.Menu print = new Models.Menu("Start", 0);
            Models.Order menu = new Models.Order(2);
            Models.Order menu2 = new Models.Order(0);
            Models.Order menu3 = new Models.Order(1);
        }
    }
}
