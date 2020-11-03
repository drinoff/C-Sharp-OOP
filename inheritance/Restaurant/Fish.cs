using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Fish : MainDish
    {
        public Fish(string name, decimal price)
            : base(name, price,0)
        {

        }
        private double grams = 22;
        public override double Grams { get => grams; }
    }
}
