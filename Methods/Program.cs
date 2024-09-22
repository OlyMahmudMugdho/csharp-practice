class Methods
{
    public static void showMessage(string message = "Hello")
    {
        Console.WriteLine(message);
    }

    public static int sum(int x, int y)
    {
        return x + y;
    }

    public static void Main(string[] args)
    {
        showMessage();
        showMessage("Good Morning");
        Console.WriteLine(sum(7,8));
    }
}