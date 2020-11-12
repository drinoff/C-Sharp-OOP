using System;
using System.Collections.Generic;
using System.Text;

namespace wildFarm.Models.Animals
{
    public class Hen : Bird
    {
        public Hen()
        {

        }
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            this.eatableFood = new List<Type>() { typeof(Vegetable), typeof(Meat), typeof(Seeds), typeof(Fruit) };
            this.weightModifier = 0.35;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
