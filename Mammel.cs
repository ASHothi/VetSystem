using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Mammel : Animal
    {
        public Mammel(string name, double weight, string gender, double height, int age)
            : base(name, weight, gender, height, age)
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
