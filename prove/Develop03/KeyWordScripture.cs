using System;

public class KeyWordScripture
{
    private string keyWord;

    static string scriptureKeyOptions = $@"
    ********************************************
                Key Word Options
    ********************************************
                  1.  Light
                  2.  Water
                  3.  Loved
                  4.  Doctrine
                  5.  Glory
                  6.  Christ
                  7.  Wisdom
                  8.  Faith
                  9.  Works
                  10. Life
    ---------------------------------------------
      Enter your selection: ";

    public string Keyword()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(scriptureKeyOptions);
        Console.ResetColor();
        
        int userInput = int.Parse(Console.ReadLine());

        switch (userInput)
        {
            case 1:
                keyWord = "light";
                break;
            case 2:
                keyWord = "water";
                break;
            case 3:
                keyWord = "loved";
                break;
            case 4:
                keyWord = "doctrine";
                break;
            case 5:
                keyWord = "glory";
                break;
            case 6:
                keyWord = "Christ";
                break;
            case 7:
                keyWord = "wisdom";
                break;
            case 8:
                keyWord = "faith";
                break;
            case 9:
                keyWord = "works";
                break;
            case 10:
                keyWord = "life";
                break;
        }

        return keyWord;
    }
}