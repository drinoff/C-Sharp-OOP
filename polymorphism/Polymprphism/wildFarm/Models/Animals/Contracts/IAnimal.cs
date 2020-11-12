using System;
using System.Collections.Generic;
using System.Text;

namespace wildFarm.Models.Animals.Contracts
{
   public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }

        string ProduceSound();
        void Feed(IFood food);
    }
}
