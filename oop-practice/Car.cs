using Engines;

namespace Vehicles
{
    class Car : Vehicle
    {
        public Car(){
            Type = "Car";
            Name = "Mercedes";
            Engine = new CarEngine();
        }

        public override void Start() {
            Engine.Assemble();
            Console.WriteLine("Starting {0} {1}", Name, Type);
        }
        
    }
}