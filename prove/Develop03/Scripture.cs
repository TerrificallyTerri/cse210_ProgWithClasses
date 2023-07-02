using System;

public class Scripture
{
    private string _scriptureRef; //Reference
    private string _theScripture; //getScriptureline

    private string FetchScriptRef(string scripturewords)
    //Gets the reference from the scriptureline 
    {
        Reference newReference = new Reference();
        return newReference.GetScriptureRef(_theScripture);
    }

    private string FetchWords(int input)
    //fetches a full line fron the txt file.
    {
        GetScripture newScripture = new GetScripture(input);
        return newScripture.GetSelectedScripture();
    }

    private void SetScriptureRef(string scripturewords)
    {
        _scriptureRef = FetchScriptRef(scripturewords);
    }

    private void SetTheScripture(int input)
    {
        _theScripture = FetchWords(input);
    }

    public void RenderedText()
    {
        Words newWords = new Words(_theScripture);

        Console.Clear();
        // Console.WriteLine("Begin loop");

        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\x1B[4m{_scriptureRef}\x1B[0m \n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(newWords.GetScriptureWithHiddenWords());
            Console.ResetColor();

            Console.Write("\n\nPress enter to hide a word or\nWrite \"quit\" to return to the main menu: ");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break; //return to main menu
            }
            
            Console.Clear();
            newWords.HideRandomWord();

        } while (!newWords.AllWordsHidden());
        // Console.WriteLine("end loop");
    }

    public Scripture(int input)
    {
        SetTheScripture(input);
        SetScriptureRef(_theScripture);
        // RenderedText();
    }



}


