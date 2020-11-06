using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace vehicles.Models
{
    public class Bus : Vehicle
    {
        public const double consumptionModifier = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
        }
        public int People { get; set; }
        public override string Drive(double distance)
        {
            
            if (this.FuelQuantity >= distance * (this.FuelConsumption + consumptionModifier))
            {
                this.FuelQuantity -= distance * (this.FuelConsumption + consumptionModifier);
                return $"Bus travelled {distance} km";
            }
            return "Bus needs refueling";
        }
        public string DriveEmpty(double distance)
        {

            if (this.FuelQuantity >= distance * (this.FuelConsumption))
            {
                this.FuelQuantity -= distance * (this.FuelConsumption);
                return $"Bus travelled {distance} km";
            }
            return "Bus needs refueling";
        }
        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException( "Fuel must be a positive number");
            }

            else if (this.FuelQuantity + liters > this.TankCapacity)
            {
                throw new ArgumentException( $"Cannot fit {liters} fuel in the tank");

            }
            else
            {
                this.FuelQuantity += liters;
               
            }
        }
    }
}
