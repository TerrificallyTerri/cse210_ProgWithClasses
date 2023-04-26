using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        int userGuess = 0;
        string playAgain = "y";

        // Option to play again:
        do
        {
            // Can't put with other variables or it adds the total number of guesses for each while loop
            int count = 0;

            // Get magic Number
            // Use randomGenerator
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            Console.WriteLine($"What is the magic number?: {magicNumber}");
            // int magicNumber = int.Parse(Console.ReadLine());

            // While Loop
            while (userGuess != magicNumber)
            {
                // Get Guess
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());

                // Check number
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Guess Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Guess Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                count += 1;
            }
            // Display number of Guesses
            Console.WriteLine($"You guessed {count} times.");
            Console.Write("Would you like to play again? ('y/n') ");
            playAgain = Console.ReadLine();

            // continues option to play again
        } while (playAgain == "y");
    }
}