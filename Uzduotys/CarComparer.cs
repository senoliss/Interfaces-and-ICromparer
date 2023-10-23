using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotys
{
    public class CarComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.Fuel > y.Fuel)
            {
                return -1;
            }
            else if (x.Fuel < y.Fuel)
            {
                return 1;
            }
            return 0;
        }
    }
}
