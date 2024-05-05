using Animals;

class Cat : Animal
{
    private string name;

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public void sound(){
        Console.WriteLine("meow");
    }
}