using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Bat : Mammel , Flying
    {
        public Bat(string name, double weight, string gender, DateTime birthDay)
            : base(name, weight, gender, birthDay)
        {
        }
        public Bat(String Name) : this(Name, 0, null, new DateTime())
        {
        }

        public override void Eat(string food)
        {
            // implement eat method
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
