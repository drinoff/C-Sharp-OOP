using System;
using System.Collections.Generic;
using System.Text;

namespace wildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            this.eatableFood = new List<Type>() { typeof(Vegetable), typeof(Fruit) };
            this.weightModifier = 0.1;
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
