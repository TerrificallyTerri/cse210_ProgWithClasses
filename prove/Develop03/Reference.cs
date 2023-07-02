using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public string GetScriptureRef(string scriptureLine)
    {
        string[] linePiece = scriptureLine.Split(";");
        _book = linePiece[0];
        _chapter = linePiece[1];
        _startVerse = linePiece[2];
        _endVerse = linePiece[3];

        string scriptureReference = $"{_book} {_chapter}:{_startVerse}";

        if (_endVerse != "0")
        {
            scriptureReference += $"-{_endVerse}";
        }
        
        return scriptureReference;
    }
    
    public void DisplayAllScriptureReferences(List<string> scriptureLines)
    {
        List<string> scriptureReferences = new List<string>();
        
        foreach (string line in scriptureLines)
        {
            string refernce = GetScriptureRef(line);
            scriptureReferences.Add(refernce);
        }

        foreach (string reference in scriptureReferences)
        {
            Console.WriteLine($"\t{reference}");
        }
    }
}