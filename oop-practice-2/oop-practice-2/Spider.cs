namespace OopTwo;

public class Spider : Animal
{
    public bool isPoisonous;
    
    public void DisplayInfo()
    {
        Console.WriteLine($"poisonous.... Name : {this.Name}, Legs : {this.Legs}");
    }
}