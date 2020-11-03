using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICalable, IBrowsable
    {
        public string Model { get; private set; }
        public Smartphone(string model)
        {
            this.Model = model;
        }

        public string Browse(string url)
        {
            var containsInt = url.Any(char.IsDigit);
            if (!containsInt)
            {
                return $"Browsing: {url}!";
            }
            else
            {
                return "Invalid URL!";
            }
        }

        public string Call(string phoneNumber)
        {
            var isNumber = int.TryParse(phoneNumber, out int _);
            if (isNumber)
            {
                return $"Calling... {phoneNumber}";
            }
            else
            {
                return "Invalid number!";
            }
        }
    }
}
