using System;
using System.Collections.Generic;
using System.Text;

namespace wildFarm.Models.Animals
{
   public abstract class Feline : Mammal
    {
        public Feline()
        {

        }
        public Feline(string name,double weight,string livingRegion,string breed)
            :base(name,weight,livingRegion)
        {
            Breed = breed;
        }

        public string Breed { get; private set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
