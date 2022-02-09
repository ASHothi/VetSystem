using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp 
{
    internal class Penguin : Bird
    {
        public Penguin(string name, double weight) : base(name, weight)
        {
        }

        public override void Eat(string food)
        {
            // implement eat method
        }

    }
}
