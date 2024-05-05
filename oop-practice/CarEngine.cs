using Engines;

class CarEngine : Engine
{
    public void Assemble()
    {
        Name = "diesel";
        Brand = "Tesla";
        Console.WriteLine($"{Brand} {Name} engine assembled");
    }
}