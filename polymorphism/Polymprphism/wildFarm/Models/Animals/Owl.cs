using System;
using System.Collections.Generic;
using System.Text;

namespace wildFarm.Models.Animals
{
    public class Owl : Bird
    {
        public Owl()
        {

        }
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            this.eatableFood = new List<Type>() { typeof(Meat) };
            this.weightModifier = 0.25;
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
