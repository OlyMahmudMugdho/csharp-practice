namespace OopTwo;

public class Animal
{
    public string Name;
    public int Legs;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name : {this.Name}, Legs : {this.Legs}");
    }
}