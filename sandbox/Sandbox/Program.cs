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
        


    }
}