using System;
using System.Collections.Generic;
using System.Text;
using wildFarm.Models.Animals;
using wildFarm.Models.Animals.Contracts;

namespace wildFarm.Core
{
    public class AnimalCreator
    {
        public IAnimal CreateAnimal(string[] input)
        {
            IAnimal animalType = null;
            
            var animal = input[0];
            var animalName = input[1];
            var animalWeight = double.Parse(input[2]);
            

            switch (animal)
            {
                case "Cat":
                    var animalLivingRegion = input[3];
                    var animalBreed = input[4];
                    animalType = new Cat(animalName,animalWeight,animalLivingRegion,animalBreed);
                    break;
                case "Dog":
                    animalLivingRegion = input[3];
                    animalType = new Dog(animalName, animalWeight, animalLivingRegion);
                    break;
                case "Hen":
                    var wingSize = double.Parse(input[3]);
                    animalType = new Hen(animalName, animalWeight,wingSize);
                    break;
                case "Mouse":
                    animalLivingRegion = input[3];
                    animalType = new Mouse(animalName, animalWeight, animalLivingRegion);
                    break;
                case "Owl":
                    wingSize = double.Parse(input[3]);
                    animalType = new Owl(animalName, animalWeight, wingSize);
                    break;
                case "Tiger":
                    animalLivingRegion = input[3];
                    animalBreed = input[4];
                    animalType = new Tiger(animalName, animalWeight, animalLivingRegion, animalBreed);
                    break;
            }
            return animalType;
        }
    }
}
