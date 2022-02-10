using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Reptiles : Animal
    {
        public Reptiles(string name, double weight, string gender, DateTime birthDay) 
            : base(name, weight, gender, birthDay)
        {
        }

        public Reptiles(String Name) : this(Name, 0, null, new DateTime())
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
