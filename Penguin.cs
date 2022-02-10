using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp 
{
    internal class Penguin : Bird
    {
        public Penguin(string name, double weight, string gender, DateTime birthDay)
            : base(name, weight, gender, birthDay)
        {
        }

        public Penguin(String Name) : this(Name, 0, null, new DateTime())
        {
        }

        public override void Eat(string food)
        {
            // implement eat method
        }

    }
}
