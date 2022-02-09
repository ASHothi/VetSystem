﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    internal class Pigeon : Bird, Flying
    {
        public Pigeon(string name, double weight, string gender, double height, int age)
            : base(name, weight, gender, height, age)
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
