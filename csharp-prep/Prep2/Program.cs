using System;

class Program
{
    static void Main(string[] args)
    {
        // Set up variables
        string gradeLetter = "";
        // Ask for grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        // 2. Pass or Fail 
        if (gradePercentage >= 70)
        {
            Console.WriteLine("\nCongratulations! You have passed the class.");
        }
        else
        {
            Console.WriteLine("Maybe next time");
        }

        // Stretch 1: Get the symbol
        string gradeSymbol = "";
        // Get remainder
        int remainder = gradePercentage % 10;
        // Logic for Symbol
        if (remainder >= 7)
        {
            gradeSymbol = "+";
        }
        else if (remainder < 3)
        {
            gradeSymbol = "-";
        }

        // Stretch 2 & 3: Logic for exceptions
        if (gradePercentage >= 93 || gradePercentage <= 60) {
            gradeSymbol = "";
        }

        // Core 3. Print to Console
        Console.WriteLine($"Your grade is: {gradeLetter}{gradeSymbol}");
    }
}