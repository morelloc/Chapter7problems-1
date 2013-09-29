using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter7Problems
{
    class TestPizza
    {
        public static void Main()
        {
            Pizza testPizza = new Pizza();
            testPizza.Price = 10.00;
            testPizza.Diameter = 12;
            testPizza.Toppings = "pepperoni";
        }
    }
}
