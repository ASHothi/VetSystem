using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    internal class Dog : Mammel
    {
        public string breed { get; private set; }

        public Dog(string name, double weight, string gender, double height, int age, string breed)
            : base(name, weight, gender, height, age)
        {
            this.breed = breed;
        }

        public Dog(String Name) : this(Name, 0, null, 0, 0, null)
        {

        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }
    }
}
