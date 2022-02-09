using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Animal
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public double weight { get; private set; }
        public string gender { get; private set; }
        public double height { get; private set; }

        public Animal(string name, double weight, string gender, double height, int age) : base()
        {
            this.name = name;
            this.weight = weight;
            this.gender = gender;
            this.height = height;
            this.age = age;
        }

        public abstract void Eat(string food);

        public void Sleep(int lengthOfSleep)
        {
            // sleep method
        }

        public abstract Animal Reproduce(Animal otherParent);

        public abstract void Breathe();

        public string Excerete()
        {
            return "I have logged this";
        }

        public void Die()
        {
            // add die method
        }
    }
}
