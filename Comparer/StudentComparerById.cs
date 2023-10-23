using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparer
{
    internal class StudentComparerById : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Id > y.Id)
            {
                return -1;
            }
            else if (x.Id < y.Id)
            {
                return 1;
            }

            return 0;
        }
    }
}
