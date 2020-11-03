using System;
using System.Collections.Generic;
using System.Linq;

namespace foodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            var listofPersons = new List<Person>();
            var foodList = new List<IBuyer>();
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                var input = InputParser();
                switch (input.Length)
                {
                    case 3:
                        var name = input[0];
                        var age = int.Parse(input[1]);
                        var group = input[2];
                        var rebel = new Rebel(name, age, group);
                        listofPersons.Add(rebel);
                        break;
                    case 4:
                        name = input[0];
                        age = int.Parse(input[1]);
                        var id = input[2];
                        var bDay = input[3];
                        var citizen = new Citizen(name, age, id, bDay);
                        listofPersons.Add(citizen);
                        break;
                }
            }

            var personBuyingFood = Console.ReadLine();
            while (personBuyingFood != "End")
            {
                var currentPerson = listofPersons.Find(x => x.Name == personBuyingFood);
                if(currentPerson != null)
                {
                    currentPerson.BuyFood();
                }
                personBuyingFood = Console.ReadLine();
            }

            var totalFood = listofPersons.Sum(x => x.Food);
            Console.WriteLine(totalFood);

        }
        public static string[] InputParser() => Console.ReadLine().Split();
    }
}
