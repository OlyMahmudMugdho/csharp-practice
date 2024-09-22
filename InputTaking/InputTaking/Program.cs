namespace InpuTaking
{
    class InputTaking
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}");

            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is : " + age);
        }
    }
}