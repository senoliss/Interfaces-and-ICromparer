﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotys
{
    public interface IVehicle
    {
        public void Drive(int distance);
        public void Refuel(int amount);
    }
}
