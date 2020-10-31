using System;

namespace _05.PizzaCalories
{
    public class Topping
    {
        private const double Calories = 2;
        private const double Meat = 1.2;
        private const double Veggies = 0.8;
        private const double Cheese = 1.1;
        private const double Sauce = 0.9;

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => this.type;
            private set
            {

                if (value.ToLower()!= "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                
                this.type = value;
            }

        }

        public double Weight
        {
            get => this.weight;
            set
            {
                if (value<1 ||value>50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            var calories = Calories * this.weight;
            var modifier = 1.0;

            switch (this.type.ToLower())
            {
                case "meat":
                    modifier *= Meat;
                    break;
                case "veggies":
                    modifier *= Veggies;
                    break;
                case "cheese":
                    modifier *= Cheese;
                    break;
                case "sauce":
                    modifier *= Sauce;
                    break;
            }

            calories *= modifier;
            return calories;
        }
    }
}