using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Mammel : Animal
    {
        public Mammel(string name, double weight, string gender, DateTime birthDay)
            : base(name, weight, gender, birthDay)
        {
        }

        public override void Breathe()
        {
            // impelemnt breathe method
        }

        public override Mammel Reproduce(Animal otherParent)
        {
            throw null;
        }
    }
}
