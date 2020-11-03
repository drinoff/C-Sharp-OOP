using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        public Cake(string name)
            : base(name, 0,0,0)
        {
           
            
        }
        private decimal cakePrice = 5;
        private double grams = 250;
        private double calories = 1000;

        public override double Grams { get => grams; }

        public override double Calories { get => calories; }

        public override decimal Price { get => cakePrice; }
    }
}
