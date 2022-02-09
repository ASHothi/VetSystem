namespace AnimalExampleCSharp;


public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Bat myBat = new Bat("bob", 86.2, "male", 3.04, 15);

        Console.WriteLine(myBat.ToString());
        Console.WriteLine(myBat.Excerete());
    }
}


