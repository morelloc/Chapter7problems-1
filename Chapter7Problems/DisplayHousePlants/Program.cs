using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousePlant
{
    class DemoHousePlant
    {
        public static void Main()
        {
            HousePlant iris = new HousePlant();
            iris.Name = "iris";
            iris.Price = 5.00;
            iris.Food = true;

            HousePlant carnation = new HousePlant();
            carnation.Name = "carnation";
            carnation.Price = 3.00;
            carnation.Food = false;

            HousePlant rose = new HousePlant();
            rose.Name = "rose";
            rose.Price = 4.00;
            rose.Food = true;
        }
    }
}
