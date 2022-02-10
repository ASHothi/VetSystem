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
        public bool isAlive { get; private set; }
        public DateTime birthDay { get; private set; }

        public Animal(string name, double weight, string gender, DateTime birthDay) : base()
        {
            this.name = name;
            this.weight = weight;
            this.gender = gender;
            this.birthDay = birthDay;
            isAlive = true;
            Age();
        }

        public abstract void Eat(string food);

        public void Sleep(int lengthOfSleep)
        {
        }

        public abstract Animal Reproduce(Animal otherParent);

        public abstract void Breathe();

        public string Excerete()
        {
            weight--;
            return "I have logged this";
        }

        public void Age()
        {            
            DateTime dateTime = DateTime.Now;
            age = dateTime.Year - birthDay.Year;

            if (birthDay.Month != 0 && dateTime.Month > birthDay.Month)
            {
                age--;
            }

            if (birthDay.Day != 0 && dateTime.Day > birthDay.Day)
            {
                age--;
            }  
        }

        public void Die()
        {   
            if (!isAlive)
            {
                Console.WriteLine("Has already died");
            }
            else
            {
                isAlive = false;
                Console.WriteLine(name + " has died");
            }
        }
    }
}

// Todo Add multiple constructors since owners may not know height/weight and for fish you may not need to know 
