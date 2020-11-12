using System;
using System.Collections.Generic;
using System.Text;
using wildFarm.IO;
using wildFarm.Models;

namespace wildFarm.Core
{
    public  class FoodCreator
    {
        public IFood CreateFood(string[] input)
        {
            IFood foodType = null;

            var food = input[0];
            var foodQuantity = int.Parse(input[1]);
            switch (food)
            {
                case "Vegetable":
                    foodType = new Vegetable(foodQuantity); 
                    break;
                case "Fruit":
                    foodType = new Fruit(foodQuantity);
                    break;
                case "Seeds":
                    foodType = new Seeds(foodQuantity);
                    break;
                case "Meat":
                    foodType = new Meat(foodQuantity);
                    break;
            }
            return foodType;
        }
    }
}
