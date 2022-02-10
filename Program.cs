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
        List<Animal> zoo = new List<Animal>();

        Console.WriteLine("Hello what type of animal do you want to add?");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("What is their name?");
        string name = Console.ReadLine().ToLower();

        switch (index)
        {
            case 1:
                Animal dog = new Dog(name);
                zoo.Add(dog);
                InitaliseAnimalAttributes(dog);
                break;
            case 2:
                Animal cat = new Cat(name);
                zoo.Add(cat);
                InitaliseAnimalAttributes(cat);
                break;
            case 3:
                Animal bat = new Bat(name);
                zoo.Add(bat);
                InitaliseAnimalAttributes(bat);
                break;
            case 4:
                Animal goldFish = new GoldFish(name);
                zoo.Add(goldFish);
                InitaliseAnimalAttributes(goldFish);
                break;
            case 5:
                Animal lizard = new Lizard(name);
                zoo.Add(lizard);
                InitaliseAnimalAttributes(lizard);
                break;
            case 6:
                Animal parrot = new Parrot(name);
                zoo.Add(parrot);
                InitaliseAnimalAttributes(parrot);
                break;
            case 7:
                Animal penguin = new Penguin(name);
                zoo.Add(penguin);
                InitaliseAnimalAttributes(penguin);
                break;
            case 8:
                Animal pigeon = new Pigeon(name);
                zoo.Add(pigeon);
                InitaliseAnimalAttributes(pigeon);
                break;
            case 9:
                Animal rabbit = new Rabbit(name);
                zoo.Add(rabbit);
                InitaliseAnimalAttributes(rabbit);
                break;
            case 10:
                Animal snake = new Snake(name);
                zoo.Add(snake);
                InitaliseAnimalAttributes(snake);
                break;
        }


        /*Console.WriteLine("Hello, World!");

        Bat myBat = new Bat("bob", 86.2, "male", 3.04, 15);

        Console.WriteLine(myBat.ToString());
        Console.WriteLine(myBat.Excerete());

        Dog myDog = new Dog("dug", 86, "male", new DateTime(2010, 3, 6), "Husky");
        Console.WriteLine(myDog.age);*/

        void InitaliseAnimalAttributes(Animal animal)
        {
            Console.WriteLine("What is their gender?");
            animal.gender = Console.ReadLine();

            Console.WriteLine("What is their weight");
            animal.weight = double.Parse(Console.ReadLine());

            Console.WriteLine("What is their birth year");
            int BirthYear = int.Parse(Console.ReadLine());

            Console.WriteLine("What is their birth month");
            int BirthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is their birth day");
            int BirthDay = int.Parse(Console.ReadLine());

            animal.birthDay = new DateTime(BirthYear, BirthMonth, BirthDay);
        }
    }


}


