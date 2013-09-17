using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Schools
    {

        public Schools (int enrollment, string name)
        {
            int StudentsEnrolled = enrollment;
            string FullName = name;
        }


        interface IComparable
        {
            public string name { get; set; }
            public int enrollment { get; set; }
            int CompareTo(Object o);
        }
    {
        int returnVal;
        Schools temp = (Schools)object;
        if(this.enrollment > temp.enrollment)
        returnVal = 1;
        else  
        if(this.enrollment < temp.enrollment)
        returnVal = -1;
        else
        returnVal = 0;
        return returnVal;
        
    }


      
    }
}
