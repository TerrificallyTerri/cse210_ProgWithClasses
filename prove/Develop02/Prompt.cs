using System;
using System.IO;

public class Prompt
{
    public static string GetPrompt(string msg)
    {
        Console.WriteLine();
        Console.WriteLine(msg);
        // Count the number of lines in the text file
        int countLines = File.ReadLines("prompts.txt").Count();
        // Initiate new random
        Random random = new Random();
        int randomLine = random.Next(countLines);

        // use streamreader to read the file
        StreamReader reader = new StreamReader("prompts.txt");

        // Loop through file until random line is reached
        for (int i = 0; i < randomLine; i++)
        {
            reader.ReadLine();
        }
        string randomPrompt = reader.ReadLine();
        Console.WriteLine(randomPrompt);
        return randomPrompt;
    }

    public string getPrompt2()
    {
        return Prompt.GetPrompt("From getPrompt2");
    }
}