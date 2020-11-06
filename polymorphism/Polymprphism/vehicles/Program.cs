using System;
using System.Runtime.InteropServices;
using vehicles.Models;

namespace vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carInfo = InputParser();
            var fuel = double.Parse(carInfo[1]);
            var consumption = double.Parse(carInfo[2]);
            var capacity = double.Parse(carInfo[3]);
            var car = new Car(fuel, consumption, capacity);

            var truckInfo = InputParser();
            fuel = double.Parse(truckInfo[1]);
            consumption = double.Parse(truckInfo[2]);
            capacity = double.Parse(truckInfo[3]);
            var truck = new Truck(fuel, consumption, capacity);

            var busInfo = InputParser();
            fuel = double.Parse(busInfo[1]);
            consumption = double.Parse(busInfo[2]);
            capacity = double.Parse(busInfo[3]);
            //var people = int.Parse(busInfo[4]);
            var bus = new Bus(fuel, consumption, capacity);

            var linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                var input = InputParser();
                var command = input[0];
                var vehicle = input[1];
                var parameter = double.Parse(input[2]);
                switch (command)
                {
                    case "Drive":
                        switch (vehicle)
                        {
                            case "Car":
                                Console.WriteLine(car.Drive(parameter));
                                break;
                            case "Truck":
                                Console.WriteLine(truck.Drive(parameter));
                                break;
                            case "Bus":
                                Console.WriteLine(bus.Drive(parameter));
                                break;
                        }
                        break;
                    case "Refuel":
                        try
                        {
                            switch (vehicle)
                            {

                                case "Car":
                                    car.Refuel(parameter);
                                    break;
                                case "Truck":
                                    truck.Refuel(parameter);
                                    break;
                                case "Bus":
                                    bus.Refuel(parameter);
                                    break;
                            }
                            break;
                        }
                        catch (ArgumentException e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                        
                    case "DriveEmpty":
                        Console.WriteLine(bus.DriveEmpty(parameter));
                        break;
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        public static string[] InputParser() => Console.ReadLine().Split();
    }
}
