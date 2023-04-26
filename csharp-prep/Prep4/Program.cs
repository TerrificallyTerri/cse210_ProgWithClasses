using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        // Variables
        int userNumber = -1;
        List<int> numbers = new List<int>();

        // Core
        Console.WriteLine("Enter a list of numbers, type '0' when finished. ");
        // while loop to keep asking until user enter 0
        while (userNumber != 0)
        {
            Console.Write("Enter Number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Core 1: Sum
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        // Display sum
        Console.WriteLine($"The sum is {sum}");

        // Core 2: Average
        float average = (float)numbers.Average();
        // other way: 
        // float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Core 3: Max
        var max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        // Stretch 1: Smallest Positive
        int smallestPositive = numbers.Where(i => i > 0).Min();
        // other way:
        // int smallestPositive = int.MaxValue; //int.MaxValue is the biggest possible number represeted by an integer

        // foreach (int number in numbers)
        // {
        //     if (number > 0 && number < smallestPositive)
        //     {
        //         smallestPositive = number;
        //     }
        // }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Stretch 2: Print Sorted List
        numbers.Sort();
        Console.WriteLine("Sorted List: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}