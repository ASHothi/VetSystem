﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Parrot : Bird, Flying
    {
        public Parrot(string name, double weight, string gender, DateTime birthDay) 
            : base(name, weight, gender, birthDay)
        {

        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
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
