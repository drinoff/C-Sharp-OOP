using System;
using System.Collections.Generic;
using System.Linq;

namespace borderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            var entrees = new List<IIdable>();
            var input = InputParser();
            while (!input.Contains("End"))
            {
                if (input.Length == 2)
                {
                    var model = input[0];
                    var id = input[1];
                    IIdable robot = new Robot(model, id);
                    entrees.Add(robot);
                }

                else
                {
                    var name = input[0];
                    var age = int.Parse(input[1]);
                    var id = input[2];
                    IIdable citizen = new Citizen(name, age, id);
                    entrees.Add(citizen);
                }

                input = InputParser();
            }
            var detainingID = Console.ReadLine();
            foreach (var id in entrees)
            {
                var lastDigits = id.Id.TakeLast(detainingID.Length).ToList();
                
                if (string.Join("",lastDigits) == detainingID)
                {
                    Console.WriteLine(id.Id);
                }
            }

        }
        public static string[] InputParser() => Console.ReadLine().Split();
    }
}
