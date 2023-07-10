using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        int input = 0;

        string mainMenu = $@"
        ********************************************
                    Scripture Memorizer
        ********************************************
            Option 1: Random Scripture
            Option 2: Select a Key Word
            Option 3: Show Scripture References
            Option 4: Quit
        ---------------------------------------------
          Enter your selection: ";

        string goodBye = $@"
        ********************************************
                        Goodbye
        ********************************************";

        while (input != 4)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(mainMenu);
            Console.ResetColor();
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    // Console.Clear();
                    Console.WriteLine("\nOption 1 - Random Scripture");
                    Scripture scriptureMemorizer = new Scripture(input);
                    scriptureMemorizer.RenderedText();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("\nOption 2 - Key Word Scripture");
                    Scripture scriptureKeyWord = new Scripture(input);
                    scriptureKeyWord.RenderedText();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("\nOption 3 - All Scripture References\n");
                    GetScripture newScriptureReferences = new GetScripture(input);
                    List<string> _scriptures = newScriptureReferences._scriptureLines;
                    Reference allReferences = new Reference();
                    allReferences.DisplayAllScriptureReferences(_scriptures);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Please enter a number from 1 to 3");
                    break;
            }
        }
        Console.Clear();
        Console.WriteLine(goodBye);
    }
    // Methods

}