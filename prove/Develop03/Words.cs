using System;
public class Words
{
    private string _scriptureLine;
    private string[] _wordsList;
    private Random _random;
    private List<int> _hiddenWordIndices;

    public Words(string scriptureLine)
    {
        _scriptureLine = scriptureLine;
        _wordsList = GetWords(scriptureLine).Split(' ');
        _random = new Random();
        _hiddenWordIndices = new List<int>();
    }

    private string GetWords(string scriptureLine)
    {
        string[] linePiece = scriptureLine.Split(";");
        return linePiece[4].Replace("~", "\n");
    }

    public string HideRandomWord()
    {
        List<int> availableIndices = new List<int>();

        for (int i = 0; i < _wordsList.Length; i++)
        {
            if (! _hiddenWordIndices.Contains(i))
            {
                availableIndices.Add(i);
            }
        }

        if (availableIndices.Count == 0)
            return null;

        int randomIndex = _random.Next(availableIndices.Count);
        int wordIndex = availableIndices[randomIndex];
        _hiddenWordIndices.Add(wordIndex);

        string wordToHide = _wordsList[wordIndex];
        _wordsList[wordIndex] = new string('_', wordToHide.Length);

        return wordToHide;
    }

    public bool AllWordsHidden()
    {
        // Console.WriteLine(_hiddenWordIndices.Count+" VS "+_wordsList.Length);
        return _hiddenWordIndices.Count == _wordsList.Length; 
    }

    public string GetScriptureWithHiddenWords()
    {
        return string.Join(" ", _wordsList);
    }
}