using System;
using System.Collections.Generic;
using System.Text;

namespace wildFarm.Models
{
    public abstract class Food : IFood
    {
        public int Quantity { get; private set; }
    }
}
