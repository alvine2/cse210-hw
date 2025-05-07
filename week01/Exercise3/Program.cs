using System;

class Program
{
    static void Main()
    {
        // Initialize random number generator
        Random randomGenerator = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            // Core Requirement 3: Generate random magic number
            int magicNumber = randomGenerator.Next(1, 101);
            int guessCount = 0;
            int guess = 0;

            Console.WriteLine("I've picked a magic number between 1 and 100.");

            // Core Requirement 2: Loop until correct guess
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Core Requirement 1: Higher/Lower logic
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    
                    
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

             Console.Write("Would you like to play again? (yes/no) ");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "yes");
        }
    }
}
/// by kinyera alvine