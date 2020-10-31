using System;
using System.Collections.Generic;

namespace _05.PizzaCalories
{
    public class Pizza
    {
        private const int numberOfToppings = 10;

        private string name;
        private Dough dough;
        private List<Topping> toppings;
       

        public Pizza(string name,Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
            TotalCalories += dough.CalculateCalories();
        }

        public double TotalCalories { get; set; }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length > 15 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
                
            }

        }

        public void AddToppings(Topping topping)
        {
            if (this.toppings.Count>=numberOfToppings)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);

            TotalCalories += topping.CalculateCalories();
        }
    }
}