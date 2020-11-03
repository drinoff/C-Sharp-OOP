using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(int horsePower,double fuel)
            :base(horsePower,fuel)
        {

        }

        public new double DefaultFuelConsumption = 10;
        public override void Drive(double kilometers)
        {
            this.Fuel -= this.DefaultFuelConsumption * kilometers;
        }
    }
}
