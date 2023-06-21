using System;
using System.Text.Json;


public class FileManagement
{
    // reference: https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-8-0
    // Methods
    
    // to Load
    public static void LoadEntries(List<string> _entriesList)
    {
        // get the user userInput
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"\tWhat is the Json file name?: ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        string fileName = Console.ReadLine();
        Console.ResetColor();

        // read the file
        string jsonData = File.ReadAllText(fileName);
        List<string> loadedEntries = JsonSerializer.Deserialize<List<string>>(jsonData);

        _entriesList.InsertRange(0, loadedEntries);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\tEntries Loaded\n");
        Console.ResetColor();
    }

    // to Save
    public static void SaveEntries(List<string> entries)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"\tEnter the Json file name: ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        string fileName = Console.ReadLine();
        Console.ResetColor();

        string jsonData = JsonSerializer.Serialize(entries);
        File.WriteAllText(fileName, jsonData);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\tEntries saved successfully\n");
        Console.ResetColor();
    }
}
