using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    internal class Lizard : Reptiles
    {
        public Lizard(string name, double weight, string gender, DateTime birthDay) 
            : base(name, weight, gender, birthDay)
        {
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
