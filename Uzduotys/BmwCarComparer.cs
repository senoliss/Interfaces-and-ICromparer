using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotys
{
    public class BmwCarComparer : IComparer<BmwCar>
    {
        public int Compare(BmwCar? x, BmwCar? y)
        {
            if (x.Fuel > y.Fuel)
            {
                return 1;
            }
            else 
            {
                return -1;
            }
        }
    }
}
