using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        // Week 2
        List<int> numbers = new List<int>();
        List<string> words = new List<string>();
        // parentheses at end of NEW OBJECT

        // add to List
        words.Add("phone");
        words.Add("keyboard");
        words.Add("more");
        // can't add more than one
        Console.WriteLine("list");
        ShowListItems(words);

        List<string> authors = new List<string>();
        // string array
        string[] authorNames = {
            "Tom Jones",
            "Maggie Flint",
            "Horrid Henry",
            "Peter Perfect"
        };
        authors.AddRange(authorNames);
        Console.WriteLine("Author Names:");
        ShowListItems(authors);


        List<string> list3 = new List<string> // can't use int as the variable is set to string in the function
        {
            // add list elements
            "1","5","6","8","3","4","9"
        };
        ShowListItems(list3);

        // function to print items in list
        void ShowListItems(List<string> list)
        {
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }

        // Functions
        // in TitleCase

        string welcome = "Welcome to the Journal Program!";
        string options = "Please select one of the following choices: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ";
        
        Console.WriteLine(welcome);
        Console.Write(options);
        string input = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        // string date = DateTime.Now.ToString("dddd, ");
        string timeDay = DateTime.Now.ToString("HH:mm on dddd, dd MMMM yyyy");
        Console.WriteLine($"Written at {timeDay}");

        Console.WriteLine();
        
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
        
    }


    
}