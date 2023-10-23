using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotys
{
    public class Car
    {
        public string Model { get; set; }
        public int Fuel { get; set; }

        public void Drive(int distance)
        {
            if (Fuel >= distance)
            {
                Fuel -= distance;
                Console.WriteLine($"{Model} is driving {distance} km.");
            }
            else
            {
                Console.WriteLine($"{Model} CANNOT drive {distance} km! Left fuel is {Fuel}");
            }
        }

        public void Refuel(int amount)
        {

            if (amount >= 0)
            {
                Fuel += amount;
                Console.WriteLine($"{Model} has been refueled with {amount} of fuel! Total fuel is {Fuel}");
            }
            else
            {
                Console.WriteLine("Invalid refueling amount. Amount must be non-negative.");
            }
        }
    }
}
