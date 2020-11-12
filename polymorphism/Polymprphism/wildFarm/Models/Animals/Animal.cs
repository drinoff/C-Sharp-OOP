using System;
using System.Collections.Generic;
using System.Text;
using wildFarm.Models.Animals.Contracts;

namespace wildFarm.Models.Animals
{
    
    public abstract class Animal : IAnimal
    {
        
        public Animal(string name,double weight)
        {
            this.Name = name;
            this.Weight = weight;
            
        }
        internal double weightModifier;
        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public List<Type> eatableFood;

        public abstract string ProduceSound();
        public void Feed(IFood food)
        {
            if(!this.eatableFood.Contains(typeof(Food)))
            {
                throw new InvalidFoodException($"{this.GetType().Name} does not eat {food.GetType().Name}");
            }
            this.Weight += food.Quantity * weightModifier;
        }
        
            
        
    }
}
