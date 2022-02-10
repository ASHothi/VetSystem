using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp;

public class program
{
    public static void Main(string[] args)
    {
        List<PetOwner> petOwners = new List<PetOwner>();


        Console.WriteLine("Hello, is this the first time you have come to this Vet?");
        if (Console.ReadLine().Equals("y"))
        {
            Console.WriteLine("What is your name?");

            Console.WriteLine("What is your mobile phone number?");

            Console.WriteLine("What is your email address?");

            Console.WriteLine("What is your home address?");

        }





        /*Console.WriteLine("Hello, World!");

        Bat myBat = new Bat("bob", 86.2, "male", 3.04, 15);

        Console.WriteLine(myBat.ToString());
        Console.WriteLine(myBat.Excerete());

        Dog myDog = new Dog("dug");
        Console.WriteLine(myDog.birthDay.ToString("dd/MM/yyyy"));*/
    }


    public Animal CreateAnimalObject(string animal)
    {
        Animal myAnimal;

        switch (animal)
        {
         
        }

        return null;
    }
}


