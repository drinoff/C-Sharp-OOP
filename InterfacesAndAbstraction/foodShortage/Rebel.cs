using System;
using System.Collections.Generic;
using System.Text;

namespace foodShortage
{
    public class Rebel : Person,INameable,IBuyer
    {
        private string name;
        

        public Rebel(string name,int age,string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            

        }
        
        public int Age { get; set; }
        public string Group { get; set; }
        

        public override void BuyFood()
        {
            this.Food += 5;
        }
    }
}
