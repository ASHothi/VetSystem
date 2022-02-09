namespace AnimalExampleCSharp;


public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Bat myBat = new Bat("bob", 5, "male");

        Console.WriteLine(myBat.ToString());
        Console.WriteLine(myBat.Excerete());
    }
}


