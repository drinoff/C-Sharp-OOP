using System;
using System.Collections.Generic;
using System.Text;
using wildFarm.IO;
using wildFarm.Models;

namespace wildFarm.Core
{
    public static class FoodCreator
    {
        public static IFood CreateFood(string food)
        {
            IFood foodType = null;
            switch (food)
            {
                case "Vegetable":
                    foodType = new Vegetable(); 
                    break;
                case "Fruit":
                    foodType = new Fruit();
                    break;
                case "Seeds":
                    foodType = new Seeds();
                    break;
                case "Meat":
                    foodType = new Meat();
                    break;
            }
            return foodType;
        }
    }
}
