using System;
using System.Collections.Generic;
using System.Text;

namespace wildFarm.Models.Animals
{
    public class Cat : Feline
    {
        public Cat(string name,double weight,string livingRegion,string breed)
            :base(name,weight,livingRegion,breed)
        {
            this.eatableFood = new List<Type>() { typeof(Vegetable), typeof(Meat) };
            this.weightModifier = 0.3;
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
