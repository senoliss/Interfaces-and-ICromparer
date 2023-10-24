using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotys
{
    public class AudiCar : Car
    {
        public bool IsQuattro { get; set; }

        public AudiCar() { }
        public AudiCar(bool isQuattro, string model, int fuel)
        {
            IsQuattro = isQuattro;
            Model = model;
            Fuel = fuel;
        }
    }
}
