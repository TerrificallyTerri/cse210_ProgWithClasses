using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        int userInput;
        string menuOptions = @$"
Menu Options:
    
    1.  Start Breathing activity
    2.  Start Reflection activity
    3.  Start Listing activity
    4.  Quit
        
Select a choice from the menu: ";

        do
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"********** Mindfulness Program************");
            Console.ResetColor();
            Console.Clear();
            Console.Write(menuOptions);
            userInput = int.Parse(Console.ReadLine());

            {
                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Option 1");
                        var breathing = new BreathingActivity(userInput);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"Option 2");
                        var reflecting = new ReflectionActivity(userInput);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"Option 3");
                        var listing = new ListingActivity(userInput);
                        break;
                }
            }
        } while (userInput != 4);
        Console.Clear();
        Console.WriteLine($"Option 4\n\n");
        Console.WriteLine($"Exit");
        Thread.Sleep(3000);


        // not past this line
    }
}