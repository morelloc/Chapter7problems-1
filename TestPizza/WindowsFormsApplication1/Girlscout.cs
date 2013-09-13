using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Girlscout
    {
        private string name;
        private int troop;
        private int dues;
        public static string motto = ("to obey the Girl Scout law");

        public Girlscout(int troop, int dues, string name)
        {
           int TroopNumber = troop;
           string FullName = name;
           int MoneyOwed = dues;
        }
    
       
        public Girlscout();
            troop = 0
            name = "sally"
            dues = 0

            
        
        
        public Girlscout() : this(0.0, 0.0, "XXX")
         {

         }
        public string name (get; set;)
    }
}
