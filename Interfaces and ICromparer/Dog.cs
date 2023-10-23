using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_ICromparer
{
    public class Dog : IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("Woof-Woof!");
        }
    }
}
