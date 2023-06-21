using System;

public class Prompt
{
    // Methods
    public string GetPrompt()
    {
        // Console.WriteLine("You have accessed the public method of GetPrompt");
        // Count the number of lines in the Prompt text file:
        int countLines = File.ReadLines("prompts.txt").Count();
        // initiate new random
        Random lineNumber = new Random();
        int randomLine = lineNumber.Next(countLines);

        // use stream reader to read the file
        StreamReader reader = new StreamReader("prompts.txt");

        // loop through file until random line is reached
        for (int i = 0; i < randomLine; i++){
            reader.ReadLine();
        }
        string randomPrompt = reader.ReadLine();

        return randomPrompt;
    }
}