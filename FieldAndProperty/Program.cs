using FieldAndProperty;

namespace FieldProperty
{
    class Practice
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.SetName("car");
            Console.WriteLine(vehicle.GetName());

            vehicle.Wheels = 4;
            Console.WriteLine(vehicle.Wheels);

            vehicle.Description = "a new car";
            Console.WriteLine(vehicle.Description);
        }
    }
}