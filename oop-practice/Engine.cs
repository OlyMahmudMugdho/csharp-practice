namespace Engines
{
    abstract class Engine
    {
        private string name;
        private string brand;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Brand {
            get { return brand; }
            set { brand = value; }
        }


        public void Assemble(){
            Console.WriteLine("engine assembled");
        }
    }
}