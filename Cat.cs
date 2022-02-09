using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Cat : Mammel
    {
        public Cat(string name, double weight) : base(name, weight)
        {
        }

        public override void Eat(string food)
        {
            // implement eat method
        }
    }
}
