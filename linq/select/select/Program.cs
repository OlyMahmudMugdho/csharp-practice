namespace select;
public class Selecting
{
    public static void Main(string[] args)
    {
        List<Person> list = new List<Person>()
        {
            new Person{Name = "Mugdho", Age = 24},
            new Person{Name = "Mila",  Age = 23}
        };

        var allPerson = list.Select(p => p.Name);

        foreach(var person in allPerson)
        {
            Console.Write($"{person}  ");
        }
    }
}