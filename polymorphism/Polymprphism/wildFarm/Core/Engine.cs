using System;
using System.Collections.Generic;
using System.Text;
using wildFarm.Core.Contracts;
using wildFarm.IO;
using wildFarm.Models;
using wildFarm.Models.Animals;
using wildFarm.Models.Animals.Contracts;

namespace wildFarm.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private List<IAnimal> animals = new List<IAnimal>();
        private AnimalCreator animalCreator;
        private FoodCreator foodCreator;

        public void Run()
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var foodCreator = new FoodCreator();
            var animalCreator = new AnimalCreator();

            while (true)
            {
                var input = reader.Read();

                if (input == "End")
                {
                    break;
                }               
                var animal = animalCreator.CreateAnimal(input.Split());                
                input = reader.Read();
                var food = foodCreator.CreateFood(input.Split());
                writer.Write(animal.ProduceSound());
                try
                {
                    animal.Feed(food);
                }
                catch (InvalidFoodException ife)
                {
                    writer.Write(ife.Message);
                }
                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                writer.Write(animal.ToString());
            }
        }
    }
}
