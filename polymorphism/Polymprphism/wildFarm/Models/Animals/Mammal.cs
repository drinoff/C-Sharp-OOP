using System;
using System.Collections.Generic;
using System.Text;

namespace wildFarm.Models.Animals
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name,double weight,string livingRegion)
            :base(name,weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
