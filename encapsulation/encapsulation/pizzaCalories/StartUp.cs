using System;

namespace _05.PizzaCalories
{
    public class Startup
    {
        public static void Main()
        {
            try
            {
                var pizzaInput = Console.ReadLine();
                var doughInput = Console.ReadLine().Split();
                var flourType = doughInput[1];
                var bakingTechnique = doughInput[2];
                var doughWeight = double.Parse(doughInput[3]);
                var dough = new Dough(flourType, bakingTechnique, doughWeight);
                var pizza = new Pizza(pizzaInput?.Substring(6, pizzaInput.Length - 6), dough);

                while (true)
                {
                    var toppingInput = Console.ReadLine().Split();

                    if (toppingInput[0] == "END")
                    {
                        break;

                    }

                    var type = toppingInput[1];
                    var weight = double.Parse(toppingInput[2]);
                    var topping = new Topping(type, weight);
                    pizza.AddToppings(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:F2} Calories.");
            }

            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
}