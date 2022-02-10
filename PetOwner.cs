using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class PetOwner
    {
        public string name { get; set; }
        public int phoneNumber { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public Animal pet { get; set; } 

        public PetOwner(string name, int phoneNumber, string email, string address, Animal pet) 
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.pet = pet;
        }

        public PetOwner(string name, Animal pet) 
            : this(name, 0, "default", "default", pet)
        {
        }

    }
}
