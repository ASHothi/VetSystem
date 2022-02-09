using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Fish : Animal
    {
        public Fish(string name, double weight, string gender, double height, int age) 
            : base(name, weight, gender, height, age)
        {
        }
    }
}
