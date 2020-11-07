using System;
using System.Collections.Generic;
using System.Text;

namespace raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name)
            :base(name)
        {
            this.Power = 100;
        }
        public override string CastAbility()
        {
            return $"Paladin - {this.Name} healed for {this.Power}";
        }
    }
}
