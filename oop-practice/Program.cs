using System;
using Animals;

namespace OOP
{
    class Program
    {
        public static void Main(string[] args){
            Animal bird = new Animal();
            bird.Type = "Chicken";
            bird.Legs = 2;

            Cat cat = new Cat();
            cat.Type = "Munchkin";
            cat.Name = "Kiki";
            cat.Legs = 4;

            Console.WriteLine($"{bird.Type} has {bird.Legs} legs");
            Console.WriteLine($"{cat.Name} is a {cat.Type} cat");
            Console.WriteLine($"{cat.Name} has {cat.Legs} short  legs");

            bird.sound();
            cat.sound();
        }
    }
}