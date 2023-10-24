using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotys
{
    public class BmwCar : Car
    {
        public bool IsXDrive { get; set; }
        public BmwCar()
        { 
        
        }
        public BmwCar(bool isXDrive, string model, int fuel) 
        {
            IsXDrive = isXDrive;
            Model = model;
            Fuel = fuel;
        }
    }
}
