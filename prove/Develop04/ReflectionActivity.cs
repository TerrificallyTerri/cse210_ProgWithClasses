using System;

public class ReflectionActivity : Activity
{
    // // Attributes
    // private string _reflectFile = "reflect.txt";
    // private string _promptFile = "prompt.txt";

    TimePieces timePieces = new TimePieces();
    // Constructors
    public ReflectionActivity(int input) : base(input)
    {
        PrepareToBegin();
        ReflectionQuestion("reflect.txt");
        ReflectionPrompts("prompt.txt", _activityDuration);
        DisplayActivityEnd();
    }

    // Methods

    public void ReflectionQuestion(string reflectFile)
    {
        List<string> shownLines = new List<string>();

        int countLines = File.ReadLines(reflectFile).Count();

        Random lineNr = new Random();
        int line = lineNr.Next(countLines);

        StreamReader reader = new StreamReader(reflectFile);

        for (int i = 0; i < line; i++)
        {
            reader.ReadLine();
        }
        string reflectQuestion = reader.ReadLine();

        // Display the prompt
        Console.WriteLine($"\n\nConsider the following prompt:\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"----{reflectQuestion}----");
        Console.ResetColor();
        Console.Write($"\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();
    }
    public void ReflectionPrompts(string promptFile, int _activityDuration)
    {
        List<string> shownLines = new List<string>();

        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("\nYou may begin in: ");
        timePieces.CountDown(5);
        Console.WriteLine();

        int duration = _activityDuration;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            TimeSpan remainingTime = endTime - DateTime.Now;
            if (remainingTime.TotalSeconds >= 5)
            {
                string promptQuestion;

                string[] allLines = File.ReadAllLines(promptFile);

                if (shownLines.Count == allLines.Length)
                {
                    shownLines.Clear();
                }

                Random randLine = new Random();

                do
                {
                    int lineIndex = randLine.Next(allLines.Length);
                    promptQuestion = allLines[lineIndex];
                }
                while (shownLines.Contains(promptQuestion));

                shownLines.Add(promptQuestion);

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($"\n>>{promptQuestion} >> ");
                Console.ResetColor();

                timePieces.Spinner(5);
            }
        }
    }
}