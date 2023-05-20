using AbstractFactory;
using AbstractFactory.WearFactory;

Console.WriteLine("~~~ Wear Factory ~~~\n");

Console.WriteLine("What are we working on today? ");

Console.WriteLine("M - Men's Wear");
Console.WriteLine("W - Women's Wear");
Console.WriteLine("C - Children's Wear");

Console.Write("\n>>");

string wearName = Console.ReadLine()!;

IWearFactory factory = wearName.ToLower() switch
{
    "m" => new MensClothingFactory(),
    "w" => new WomensClothingFactory(),
    "c" => new ChildrensClothingFactory(),
    _ => null!
};

if (factory != null)
{
    Wear wear = new Wear(factory);

    Console.WriteLine($"\n{wear}");
}
else
{
    Console.WriteLine("\nInvalid input.");
}
