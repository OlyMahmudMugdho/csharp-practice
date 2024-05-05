using Engines;

namespace Vehicles
{
    abstract class Vehicle
    {
        private string type;
        private string name;

        private Engine engine;

        public string Type {
            get { return type; }
            set { type = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public Engine Engine{
            get { return engine; }
            set { engine = value; }
        }

        public abstract void Start();
    }
}