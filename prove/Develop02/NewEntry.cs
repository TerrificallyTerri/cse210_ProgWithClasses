using System;

public class NewEntry
{
    // 
    public string _thisPrompt = RandoPrompt();
    public string _timeStamp = DateTime.Now.ToString("HH:mm on dddd, dd MMMM yyyy");

    public string _userResponse;

    public static List<string> _entriesList = new List<string>();

    // Methods
    static string RandoPrompt()
    {
        // instantiate new object from class
        Prompt firstPrompt = new Prompt();
        // Call Method
        string prompt = firstPrompt.GetPrompt();
        return prompt;
    }

    public string UserEntry()
    {
        // Prompt for input
        Console.WriteLine($"{_timeStamp}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"   Prompt: {_thisPrompt}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write($"\nEnter your Response here: \n>>> ");
        Console.ResetColor();

        // Variables
        string userInput = string.Empty;
        int enterCount = 0;

        // While loop to automatically exit entry mode when "enter is pushed twice
        while (enterCount < 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string input = Console.ReadLine();
            Console.ResetColor();

            if (string.IsNullOrEmpty(input))
            {
                enterCount++;
            }
            else{
                // include the new empty line together with all that had been entered before
                userInput += input + Environment.NewLine;
                // return the counter to 0
                enterCount = 0;
            }
        }
        // Add entry to List

        string entry = $"\t{_timeStamp}\n\tThe prompt given:\n\t{_thisPrompt}\n\tYour response: >>>\n\t{userInput}";
        _entriesList.Add(entry);

        return userInput;
    } 

    public static void Display()
    {
        foreach (string line in NewEntry._entriesList)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*****");
            Console.WriteLine(line);
            Console.ResetColor();
        }
    }
}