using System;

class Program
{
    static void Main()
    {
        var a = 10;
        var b = 10;

        if (a == b)
        {
            Console.WriteLine("These have the same value");
        }

        var p1 = new Person() { Name = "Michael", Count = 100 };
        var p2 = new Person() { Name = "Michael", Count = 100 };

        if (p1 == p2)
        {
            Console.WriteLine("Have the same reference");
        }
        else
        {
            Console.WriteLine("These are pointing to different addresses");
        }
    }
}

public class Person
{
    public string Name { get; set; }
    public int Count { get; set; }
}
