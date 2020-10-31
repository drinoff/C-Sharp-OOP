using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace pizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var input = InputParser();
                var toppingInput = InputParser();
                while (!input.Contains("END"))
                {
                    var flourType = input[1];
                    var bakingTechnique = input[2];
                    var weight = double.Parse(input[3]);
                    var dough = new Dough(flourType, bakingTechnique, weight);
                    Console.WriteLine($"{dough.Calories:f2}");

                    var toppingType = toppingInput[1];
                    var toppingWeight = double.Parse(toppingInput[2]);
                    var topping = new Topping(toppingType, toppingWeight);
                    Console.WriteLine($"{topping.Calories:f2}");
                    input = InputParser();
                }
            }
            catch (Exception msg)
            {

                Console.WriteLine(msg.Message);
            }
        }
        public static string[] InputParser() => Console.ReadLine().Split();
    }
}
