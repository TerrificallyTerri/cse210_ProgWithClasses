using System;

public class GetScripture
{
    public List<string> _scriptureLines { get; private set; } = new List<string>();
    private string _scriptureRef;
        
    // Constructors
    public GetScripture(int input)
    {
        CompileScriptureList();
        _scriptureRef = GetTheScripture(input);
    }

    // Create a list with all the scripture lines
    public void CompileScriptureList()
    {
        string filePath = "scriptures_library.txt";
        string line;

        StreamReader reader = new StreamReader(filePath);
        while ((line = reader.ReadLine()) != null)
        {
            _scriptureLines.Add(line);
        }
    }

    // Get a Randomscripture
    private string GetTheScripture(int input)
    {
        if (input == 1)
        {
            int countLines = _scriptureLines.Count();
            Random lineNumber = new Random();
            int randomLineIndex = lineNumber.Next(countLines);
            return _scriptureLines[randomLineIndex];
        }
        else if (input == 2)
        {
            KeyWordScripture keyWordScripture = new KeyWordScripture();
            string selectedKeyWord = keyWordScripture.Keyword();

            // LINQ expression used to filter through the _scriptureLines list to find the match for the given keyword
            List<string> matchingLines = _scriptureLines.Where(line => line.Contains(selectedKeyWord)).ToList();
            Random randomNumber = new Random();
            int randoLineIndex = randomNumber.Next(matchingLines.Count);
            return matchingLines[randoLineIndex];
        }
        else
        {
            return $"That input was not valid";
        }
    }

    public string GetSelectedScripture()
    {
        return _scriptureRef;
    }
}