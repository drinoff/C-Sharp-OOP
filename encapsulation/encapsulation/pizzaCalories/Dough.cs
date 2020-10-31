using System;

namespace _05.PizzaCalories
{
    public class Dough
    {
        private const double Calories = 2;
        private const double White = 1.5;
        private const double Wholegrain = 1.0;
        private const double Crispy = 0.9;
        private const double Chewy = 1.1;
        private const double Homemade = 1.0;

        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get => this.flourType;
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;

            private set
            {
                if (value.ToLower()!= "crispy"&&value.ToLower()!= "chewy"&& value.ToLower()!= "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            var calories = Calories * this.weight;
            var modifier = 1.0;
            switch (this.flourType.ToLower())
            {
                case "white":
                    modifier *= White;
                    break;
                case "wholegrain":
                    modifier *= Wholegrain;
                    break;
                default:
                    modifier = 1;
                    break;
            }

            switch (this.bakingTechnique.ToLower())
            {
                case "crispy":
                    modifier *= Crispy;
                    break;
                case "chewy":
                    modifier *= Chewy;
                    break;
                case "homemade":
                    modifier *= Homemade;
                    break;
            }

            calories *= modifier;

            return calories;
        }
    }
}
