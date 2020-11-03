using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICalable
    {
        public string Call(string phoneNumber)
        {

            var isNumber = int.TryParse(phoneNumber, out int _);
            if (isNumber)
            {
                return $"Dialing... {phoneNumber}";
            }
            else
            {
                return "Invalid number!";
            }


        }
    }
}
