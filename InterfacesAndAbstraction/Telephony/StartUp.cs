using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var phoneNumbers = InputParser();
            var URLAdresses = InputParser();
            var smarthPhone = new Smartphone("Smartphone");
            var stationary = new StationaryPhone();
            
                foreach (var phone in phoneNumbers)
                {
                    if (phone.Length == 7)
                    {
                        Console.WriteLine(stationary.Call(phone));
                    }
                    else
                    {
                        Console.WriteLine(smarthPhone.Call(phone));
                    }
                }
                foreach (var url in URLAdresses)
                {
                    Console.WriteLine(smarthPhone.Browse(url));
                }
            
           
            
        }
        public static string[] InputParser() => Console.ReadLine().Split();
    }
}
