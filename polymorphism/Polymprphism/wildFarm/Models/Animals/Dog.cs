using System;
using System.Collections.Generic;
using System.Text;

namespace wildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            this.eatableFood = new List<Type>() { typeof(Meat) };
            this.weightModifier = 0.4;
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
