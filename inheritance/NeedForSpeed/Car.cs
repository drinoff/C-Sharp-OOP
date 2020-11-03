using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }

        public new double DefaultFuelConsumption = 3;

        public override void Drive(double kilometers)
        {
            this.Fuel -= this.DefaultFuelConsumption * kilometers;
        }
    }
}
