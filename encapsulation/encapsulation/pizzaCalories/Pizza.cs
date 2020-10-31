using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pizzaCalories
{
    class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private double calories;

        public Pizza(string name)
        {
            this.name = name;
            toppings = new List<Topping>();
            this.Calories = calories;
        }

        public string Name { get => this.name; }
        public int ToppingsCount { get => this.toppings.Count; }

        public double Calories 
        {
            get => this.calories;
            set { this.Calories = this.dough.Calories + toppings.Sum(x => x.Calories); }
        }
        public Dough Dough
        {
            get;
            set
            {
                this.Dough.flourType = value;
            }
        }

        
    }
}
