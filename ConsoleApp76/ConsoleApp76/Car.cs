using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar6_1
{
    internal class Car : Vehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelFor1km { get; set; }

        public override void Drive(double km)
        {
            if (FuelFor1km * km < CurrentFuel)
            {
                CurrentFuel -= FuelFor1km * km; // currentFuel = currentFuel - fuelFor1Km * km
                Millage += km;
            }
        }
    }
}