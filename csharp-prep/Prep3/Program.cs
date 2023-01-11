// Terrystan N. Sustal - Guessing Game | Prep 3

using System;

class Program
{
    static void Main(string[] args)
    {
        // Steps 1 & 2: Ask the user for the Magic Number
        // Console.Write("Please enter the Magic Number: ");
        // string magicNumber = Console.ReadLine();
        // int number = int.Parse(magicNumber);

        // Step 3: Have a random generator
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        // Have an int variable set to 0
        int numberGuess = 0;
        int guesses = 0;
        
        // Introduce the user to the game
        Console.WriteLine("Welcome to the Guessing Game!");

        //  Have a while loop. This while loop will run until the user guesses the right Magic Number
        // If the user doesn't guess the Magic Number, the code will continue to run
        // Expected outcome: "Higher", "Lower", and "You guessed it!"
        while (numberGuess != number)
        {

            Console.Write("What is your guess: ");
            numberGuess = int.Parse(Console.ReadLine());

            if (numberGuess > number)
            {
                Console.WriteLine();
                Console.WriteLine("Lower");           
            }

            else if (numberGuess < number)
            {
                Console.WriteLine();
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("You guessed it!");
            }

            // Increases the value of a variable by 1 (increment)
            guesses++;
        }
        Console.WriteLine($"Number of guesses: {guesses}");

        Console.WriteLine();
        Console.WriteLine("Thanks for playing!");
        Console.WriteLine();
    }
}