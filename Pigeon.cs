using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    internal class Pigeon : Bird, Flying
    {
        public Pigeon(string name, double weight, string gender, DateTime birthDay)
            : base(name, weight, gender, birthDay)
        {
        }

        public Pigeon(String Name) : this(Name, 0, null, new DateTime())
        {
        }

        public override void Eat(string food)
        {
            // Implement eat method
        }

        public void Flight()
        {
            throw new NotImplementedException();
        }

        public void Landing()
        {
            throw new NotImplementedException();
        }

        public void TakeOff()
        {
            throw new NotImplementedException();
        }
    }
}
