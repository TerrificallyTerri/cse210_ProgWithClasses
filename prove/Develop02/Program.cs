using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You got this");

        // Variables
        // variable to hold user choice
        int input = 0;
        // welcome text
        string welcome = "\nWelcome to Your Journal!\n";
        // Display user options
        string options =  "Please select one of the following choices: \n\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\nWhat would you like to do? ";

        // Welcome lines:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(welcome);
        Console.ResetColor();

        // User directing
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(options);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            input = int.Parse(Console.ReadLine());
            Console.ResetColor();

            switch (input)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nOption 1 - New Entry\n");
                    Console.ResetColor();
                    // Create (instantiate) new instance (object) of NewEntry
                    NewEntry entry = new NewEntry();
                    entry.UserEntry();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nOption 2 - Display Entries\n");
                    Console.ResetColor();

                    if (NewEntry._entriesList.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("There are no entries yet");
                        Console.ResetColor();
                    }
                    else
                    {
                        NewEntry.Display();
                    }
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nOption 3 - Load Entries from File\n");
                    Console.ResetColor();
                    // Create (instantiate) new instance (object) of NewEntry
                    FileManagement.LoadEntries(NewEntry._entriesList);
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nOption 4 - Save Entries to File\n");
                    Console.ResetColor();
                    // Create new instance of FileManagement
                    FileManagement.SaveEntries(NewEntry._entriesList);
                    break;
            }

        } while (input != 5);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nOption 5 - EXIT\nGOOD BYE");
        Console.ResetColor();
    }
}