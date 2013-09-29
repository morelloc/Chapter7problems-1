using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolsDemo
{
    class School : IComparable
    {
        private int enrollment;

        public int Enrollment { get; set; }

        int IComparable.CompareTo(Object other)
        {
            School otherSchool = (School)other;

            if (this.Enrollment < otherSchool.Enrollment)
                return -1;
            else if (this.Enrollment > otherSchool.Enrollment)
                return 1;

            return 0;
        }

    }
}
