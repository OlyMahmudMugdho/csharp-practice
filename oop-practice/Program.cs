using System;
using Animals;

namespace OOP
{
    class Program
    {
        public static void Main(string[] args){
            Animal animal = new Animal();
            animal.Type = "cat";
            animal.Legs = 4;
            Console.WriteLine($"{animal.Type} has {animal.Legs} legs");
        }
    }
}