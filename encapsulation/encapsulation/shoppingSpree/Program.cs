using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace shoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>();
            var persons = new List<Person>();
            var separator = new char[] { ';', '=' };
            var input = InputParser(separator);
            for (int i = 0; i < input.Length; i += 2)
            {
                try
                {
                    var name = input[i];
                    var money = decimal.Parse(input[i + 1]);
                    var person = CreatePerson(name, money);
                    persons.Add(person);
                }
                catch (Exception msg)
                {

                    Console.WriteLine(msg.Message);
                    return;
                }
            }

            input = InputParser(separator);
            for (int i = 0; i < input.Length; i += 2)
            {
                try
                {
                    var name = input[i];
                    var cost = decimal.Parse(input[i + 1]);
                    var product = CreateProduct(name, cost);
                    products.Add(product);
                }
                catch (Exception msg)
                {

                    Console.WriteLine(msg.Message);
                    return;
                }
            }
            var line = Console.ReadLine();
            while (line != "END")
            {
                var lineDEtails = line.Split();
                var currentPerson = lineDEtails[0];
                var currentProduct = lineDEtails[1];
                var currPerson = persons.Find(x => x.Name == currentPerson);
                var currProduct = products.Find(x => x.Name == currentProduct);
                Console.WriteLine(BuyProduct(currPerson, currProduct));
                line = Console.ReadLine();
            }
            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }

        }
        public static string[] InputParser(char[] separator) => Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries);

        public static Person CreatePerson(string name, decimal money) => new Person(name, money);

        public static Product CreateProduct(string name, decimal cost) => new Product(name, cost);

        public static string BuyProduct(Person currentPerson, Product currentProduct)
        {
            return currentPerson.BuyProduct(currentProduct);
        }
    }
}
