namespace BasicConcepts;

using System;
using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main(string[] args)
    {

        /* 
        
        *** This is a very basic use case
        
        Console.WriteLine("Hello World");
        
        Console.WriteLine("max value of int is {0}",int.MaxValue);
        Console.WriteLine("min value of int is {0}",int.MinValue);

        Console.WriteLine("What is your name");
        string name = Console.ReadLine();
        Console.WriteLine("Hello {0}",name);  

        Console.WriteLine("Enter your salary : ");
        int salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Salary {0:c}", salary); */

        /* 
        
        *** Conditionals and Booleans ***

        bool canVote = false;
       
        Console.WriteLine("What is your age?");

        int age = int.Parse(Console.ReadLine());

        if(age >= 18){
            canVote = true;
        }

        if(canVote) {
            Console.WriteLine("You can vote");
        }
        else {
            Console.WriteLine("You are a kid");
        } */

        /* 

        Array

        int[] rolls = new int[3];

        Console.WriteLine("Enter student rolls : ");

        for(int i=0; i < rolls.Length; i++) {
            Console.WriteLine($"Enter roll number {i+1}");
            rolls[i] = int.Parse(Console.ReadLine());
        }

        foreach(int roll in rolls) {
            Console.Write("{0} ", roll);
        }

        Console.WriteLine("");


        string[] names = new string[] {"Mugdho","Mila","Meghla"};

        foreach(string name in names) {
            Console.WriteLine($"{name}");
        }


        object[] mixed = new object[] {"text",85,true};

        var employees = new[] {"name", "good"};
        var codes = new [] {4,5};

        string[,] customers = new[,] {
            {"Mugdho","Mahmud"},
            {"Mila","Mahmud"},
        };

        }
 */

    }
}

