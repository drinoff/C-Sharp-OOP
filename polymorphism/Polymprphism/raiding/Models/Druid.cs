using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name)
            :base(name)
        {
            this.Power = 80;
        }

        public override string CastAbility()
        {
            
            return $"Druid - {this.Name} healed for {this.Power}";
        }
    }
}
