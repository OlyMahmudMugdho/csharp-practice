using System;

namespace OopTwo;

class Code
{
    public static void Main(string[] args)
    {
        Cat cat = new Cat()
        {
            Name = "Tom",
            Legs = 4,
            isDomestic = true
        };

        Spider spider = new Spider()
        {
            Name = "some name",
            Legs = 8,
            isPoisonous = true
        };
        
        cat.DisplayInfo();
        spider.DisplayInfo();
        
        Console.WriteLine($"cat name is {cat.Name}");
        cat.Name = "Kiki";
        Console.WriteLine($"cat name changed to {cat.Name}");
        Console.WriteLine("cat info - {0}", cat.catInfo());
    }
}

