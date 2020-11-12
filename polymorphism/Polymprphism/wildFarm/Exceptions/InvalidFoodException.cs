using System;
using System.Collections.Generic;
using System.Text;

namespace wildFarm.Models.Animals.Contracts
{
    public class InvalidFoodException : Exception
    {
        
        public InvalidFoodException(string message) : base(message)
        {
            
        }
    }
}
