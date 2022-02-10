using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class GoldFish : Fish
    {
        public GoldFish(string name, double weight, string gender, DateTime birthDay) 
            : base(name, weight, gender, birthDay)
        {
        }
        public GoldFish(String Name) : this(Name, 0, null, new DateTime())
        {
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
