using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Parrot : Bird
    {
        public Parrot(string name, double weight, string gender, double height, int age) 
            : base(name, weight, gender, height, age)
        {
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
