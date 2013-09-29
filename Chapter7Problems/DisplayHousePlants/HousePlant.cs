using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousePlant
{
    class HousePlant
    {
        private double price;
        private string name;
        private bool food;

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public bool Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
            }
        }
    }
}