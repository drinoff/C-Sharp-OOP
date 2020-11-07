using System;
using System.Collections.Generic;
using System.Text;

namespace raiding
{
    class Warrior : BaseHero
    {
        public Warrior(string name)
            :base(name)
        {
            this.Power = 100;
        }
        public override string CastAbility()
        {
            return $"Warrior - {Name} hit for {Power} damage";
        }
    }
}
