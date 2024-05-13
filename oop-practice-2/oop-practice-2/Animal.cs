namespace OopTwo;

public class Animal
{
    public string Name { get; set; }
    public int Legs { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name : {this.Name}, Legs : {this.Legs}");
    }
}