using System;
using System.Collections.Generic;
using System.Text;

namespace pizzaCalories
{
    class Topping
    {
        private const double Meat = 1.2;
        private const double Veggies = 0.8;
        private const double Cheese = 1.1;
        private const double Sauce = 0.9;

        private string toppingType;
        private double weight;
        private double toppingTypeMod;
        private double calories;

        public Topping(string toppingType, double weight)
        {
            this.toppingType = toppingType;
            this.Calories = calories;
            this.Weight = weight;
        }

        
        public double Calories
        {
            get { return this.calories; }
            private set
            {
                this.toppingTypeMod = ToppingTypeModifierSetter(toppingType);
                calories = 2 * this.weight * this.toppingTypeMod;
            }
        }

        private double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        private double ToppingTypeModifierSetter(string toppingType)
        {
            if (toppingType == "meat"|| toppingType == "Meat")
            {
                this.toppingTypeMod = Meat;
            }
            else if (toppingType == "veggies"|| toppingType == "Veggies")
            {
                this.toppingTypeMod = Veggies;
            }
            else if (toppingType == "cheese"|| toppingType == "Cheese")
            {
                this.toppingTypeMod = Cheese;
            }
            else if (toppingType == "sauce"|| toppingType == "Sauce")
            {
                this.toppingTypeMod = Sauce;
            }
            else
            {
                throw new ArgumentException($"Cannot place {toppingType} on top of your pizza.");
            }
            return this.toppingTypeMod;
        }
    }
}
