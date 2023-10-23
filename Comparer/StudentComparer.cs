using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparer
{
    internal class StudentComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x == null)
            {
                return -1;
            }
            else if (y == null)
            {
                return 1;
            }
            //if (x.Year > y.Year)
            //{
            //	return -1;
            //}
            //else if (x.Year < y.Year)
            //{
            //	return 1;
            //}

            //return 0;

            return string.Compare(x.Name, y.Name);
        }
    }
}
