using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Schools[] school;
            school = new Schools[10];


            for (int i = 0; i < school.Length; i++)
            {
                school[i] = new Schools();
                school[i].enrollment = 0;
            }

        }
    }
}