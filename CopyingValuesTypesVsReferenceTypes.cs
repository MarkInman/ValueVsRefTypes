using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--------------------------VALUE TYPES-----------------------");

        int x = 10;
        int y = 20;

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");

        x = y; // Make a copy of y

        Console.WriteLine("");
        Console.WriteLine("increment x");

        x++;

        Console.WriteLine("");
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");

        Console.WriteLine("--------------------------REFERENCE TYPES-----------------------");

        var p1 = new Person() { Name = "Michael", Count = 100 };
        var p2 = new Person() { Name = "Jason", Count = 200 };

        p1 = p2; // Copy the reference to p2

        Console.WriteLine("");
        Console.WriteLine($"p1.Name = '{p1.Name}', p1.Count = {p1.Count}");
        Console.WriteLine($"p2.Name = '{p2.Name}', p2.Count = {p2.Count}");

        Console.WriteLine("");
        Console.WriteLine("change the values of p2");

        p2.Name = "Freddy";
        p2.Count++;

        Console.WriteLine("Notice that the values of p1 also change");
        Console.WriteLine($"p1.Name = '{p1.Name}', p1.Count = {p1.Count}");
        Console.WriteLine($"p2.Name = '{p2.Name}', p2.Count = {p2.Count}");

        p2 = null;
        //p2.Name = "Throw NULL Reference Exception"; // This will throw an exception
    }
}

public class Person
{
    public string Name { get; set; }
    public int Count { get; set; }
}
