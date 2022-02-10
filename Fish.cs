using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Fish : Animal, Swimming
    {
        public Fish(string name, double weight, string gender, double height, int age) 
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

        public void Dive()
        {
            throw new NotImplementedException();
        }

        public void Float()
        {
            throw new NotImplementedException();
        }

        public void Surface()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
