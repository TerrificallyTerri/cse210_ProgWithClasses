using System;

public class ListingActivity : Activity
{
    // Variables
    private List<string> _userResponses = new List<string>();
    TimePieces timePieces = new TimePieces();
    // Constructors
    public ListingActivity(int input) : base(input)
    {
        PrepareToBegin();
        ListingQuestion("listing.txt");
        DisplayActivityEnd();
    }

    // Methods
    public void ListingQuestion(string listingFile)
    {
        List<string> shownLines = new List<string>();
        int countLines = File.ReadLines(listingFile).Count();
        Random lineNr = new Random();
        int line = lineNr.Next(countLines);

        StreamReader reader = new StreamReader(listingFile);

        for (int i = 0; i < line; i++)
        {
            reader.ReadLine();
        }
        string listPrompt = reader.ReadLine();

        // Display the prompt
        Console.WriteLine($"\n\nList as many responses as you can to the following prompt:\n");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"----{listPrompt}----");
        Console.ResetColor();
        Console.Write("\nYou may begin in: ");
        timePieces.CountDown(5);
        Console.WriteLine();

        int duration = _activityDuration;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now <= endTime)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($">>>  ");
            _userResponses.Add(Console.ReadLine());
            Console.ResetColor();
        }
        int entries = _userResponses.Count;
        Console.WriteLine($"You have listed {entries} items!");


    }
}