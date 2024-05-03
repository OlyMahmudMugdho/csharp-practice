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
            Console.WriteLine($"{bird.Type} has {bird.Legs} legs");
            
        }
    }
}