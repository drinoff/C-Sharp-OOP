using System;
using System.Collections.Generic;
using System.Text;

namespace raiding
{
    public abstract class BaseHero
    {
        public BaseHero(string name)
        {
            this.Name = name;

        }
        public  string Name { get; set; }
        public int Power { get; set; }

        public abstract string CastAbility();
    }
}
