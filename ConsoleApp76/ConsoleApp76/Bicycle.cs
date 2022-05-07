using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar6_1
{
    internal class Bicycle : Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }
    }
}