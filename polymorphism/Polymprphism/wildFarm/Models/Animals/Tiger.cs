using System;
using System.Collections.Generic;
using System.Text;

namespace wildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            this.eatableFood = new List<Type>() { typeof(Meat)};
            this.weightModifier = 1;
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
