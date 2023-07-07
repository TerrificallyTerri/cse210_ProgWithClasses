using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        // Traditional way of initialization
        Assignment ass1 = new Assignment("Samuel Bennet", "Multiplication" );
        Console.WriteLine(ass1.Getsummary());

        var ass2 = new MathAssignment("Roberto Rodrigues", "Fractions", "7.3", "8-19");
        Console.WriteLine(ass2.Getsummary());
        Console.WriteLine(ass2.GetHomeWorkList());

        var ass3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(ass3.Getsummary());
        Console.WriteLine(ass3.GetWritingInformation());
    }
}