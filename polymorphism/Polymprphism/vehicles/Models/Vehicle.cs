using System;
using System.Collections.Generic;
using System.Text;

namespace vehicles
{
    public class Vehicle
    {
        private double tankCapacity;   
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }
        
            
        

        public Vehicle(double fuelQuantity, double fuelConsumption,double tankCapacity)
        {
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
        }

        public virtual string Drive(double kilometers)
        {
            return null;
        }

        public virtual void Refuel(double liters)
        {
            
        }
    }
}
