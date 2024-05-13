namespace OopTwo;

public class Cat : Animal
{
    public bool isDomestic;

    public void DisplayInfo()
    {
        Console.WriteLine($"meow.... Name : {this.Name}, Legs : {this.Legs}");
    }

    public string catInfo()
    {
        return $"Name : {this.Name}; Legs : {this.Legs}";
    }
}