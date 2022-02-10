using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, string gender, DateTime birthDay)
            : base(name, weight, gender, birthDay)
        {
        }

        public override void Breathe()
        {
            // implemnt breathe method
        }

        public override Mammel Reproduce(Animal otherParent)
        {
            throw null;
        }
    }
}
