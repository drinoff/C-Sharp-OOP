using System;
using System.Collections.Generic;
using System.Text;

namespace vehicles
{
    public class Truck : Vehicle
    {
        public const double refuelingModifier = 0.95;
        public const double consumptionModifier = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
        }

        public override string Drive(double distance)
        {

            if (this.FuelQuantity >= distance * (this.FuelConsumption + consumptionModifier))
            {
                this.FuelQuantity -= distance * (this.FuelConsumption + consumptionModifier);
                return $"Truck travelled {distance} km";
            }
            return "Truck needs refueling";
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
                liters *= 0.95;
                this.FuelQuantity += liters;

            }
        }
    }
}
