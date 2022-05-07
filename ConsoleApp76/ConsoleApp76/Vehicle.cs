using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar6_1
{
    abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Millage { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Color: {Color} - Millage: {Millage}");
        }

        public abstract void Drive(double km);
    }
}