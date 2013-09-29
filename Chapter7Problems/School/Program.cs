﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            School[] school = new School[5];
            for (int i = 0; i < school.Length; i++)
            {
                Console.Write("Input enrollment size of school {0}: ", i);
                string input = Console.ReadLine();
                int enrollment = Convert.ToInt32(input);
                school[i] = new School();
                school[i].Enrollment = enrollment;
            }

            Array.Sort(school);
            Console.WriteLine("Sorted Schools:");
            for (int i = 0; i < school.Length; i++)
            {
                Console.WriteLine("{0}", school[i].Enrollment);
            }

            Console.Write("Minimum enrollment size: ");
            string MinEnrollment = Console.ReadLine();
            int minEnrollment = Convert.ToInt32(MinEnrollment);

            for (int i = 0; i < school.Length; i++)
            {

                if (school[i].Enrollment>= minEnrollment)
                    Console.WriteLine(school[i].Enrollment);
            }
        }
    }
}
