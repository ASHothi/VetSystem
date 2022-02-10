using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    internal class Snake : Reptiles
    {
        public Snake(string name, double weight, string gender, DateTime birthDay) 
            : base(name, weight, gender, birthDay)
        {
        }

        public Snake(String Name) : this(Name, 0, null, new DateTime())
        {
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
