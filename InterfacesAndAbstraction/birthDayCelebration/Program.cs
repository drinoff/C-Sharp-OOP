using System;
using System.Collections.Generic;
using System.Linq;

namespace birthDayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            var entrees = new List<IBirthable>();
            var input = InputParser();
            while (!input.Contains("End"))
            {
                if (input[0] == "Robot")
                {
                    var model = input[1];
                    var id = input[2];
                    Thing robot = new Robot(model, id);
                    
                }

                else if (input[0] == "Citizen")
                {
                    var name = input[1];
                    var age = int.Parse(input[2]);
                    var id = input[3];
                    var birthdate = input[4];
                    IBirthable citizen = new Citizen(name, age, id, birthdate);
                    entrees.Add(citizen);
                }
                else
                {
                    var name = input[1];
                    var birthdate = input[2];
                    IBirthable pet = new Pet(name, birthdate);
                    entrees.Add(pet);

                }

                input = InputParser();
            }
            var yearToCheck = Console.ReadLine();
            foreach (var id in entrees)
            {
                var lastDigits = id.Birthdate.TakeLast(4).ToList();

                if (string.Join("", lastDigits) == yearToCheck)
                {
                    Console.WriteLine(id.Birthdate);
                }
            }

        }
        public static string[] InputParser() => Console.ReadLine().Split();
    }
}
