using raiding.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace raiding.Core
{
   public class CreateHero
    {

        public BaseHero Create(string name,string spec)
        {
            BaseHero hero = null;
            switch (spec)
            {
                case "Druid":
                    hero = new Druid(name);                    
                    break;

                case "Paladin":
                    hero = new Paladin(name);                    
                    break;

                case "Rogue":
                    hero = new Rogue(name);                   
                    break;

                case "Warrior":
                    hero = new Warrior(name);                    
                    break;

                default:
                    throw new InvalidHeroException("Invalid hero!");
                    
            }
            var writer = new ConsoleWriter();
            //writer.Write(hero.CastAbility());
            return hero;
        }
    }
}
