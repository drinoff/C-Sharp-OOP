using System;
using System.Collections.Generic;
using System.Text;

namespace vehicles
{
    public class Car : Vehicle
    {
        public const double consumptionModifier = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
        }
        public override string Drive(double distance)
        {

            if (this.FuelQuantity >= distance * (this.FuelConsumption + consumptionModifier))
            {
                this.FuelQuantity -= distance * (this.FuelConsumption + consumptionModifier);
                return $"Car travelled {distance} km";
            }
            return "Car needs refueling";
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            else if (this.FuelQuantity + liters > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");

            }
            else
            {
                this.FuelQuantity += liters;

            }
        }
    }
}
