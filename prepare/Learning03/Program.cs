using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        string numerator =  fraction1.GetFractionsString();
        double dec = fraction1.GetDecimalValue();
        Console.WriteLine(numerator);
        Console.WriteLine(dec);

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionsString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionsString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionsString());
        Console.WriteLine(fraction4.GetDecimalValue());
        Console.WriteLine(fraction4.GetBottom());

        // Use of only the getters and setters
        Fraction fraction5 = new Fraction();
        fraction5.SetTop(5);
        fraction5.SetBottom(10);
        Console.WriteLine($"Showing use of Getters and Setters: {fraction5.GetDecimalValue()}");
        Console.WriteLine($"Show Bottom: {fraction5.GetBottom()}");
        Console.WriteLine($"Show Top: {fraction5.GetTop()}");
    }
}