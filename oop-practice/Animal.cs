namespace Animals
{
    class Animal
    {
        private string type;
        private int legs;

        public string Type {
            get { return type; }
            set { type = value; }
        }

        public int Legs {
            get { return legs; }
            set { legs = value; }
        }

        public void sound(){
            Console.WriteLine("animal sound");
        }
    }
}