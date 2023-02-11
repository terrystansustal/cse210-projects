// Terrystan N. Sustal | Developer 03 - Scripture Memorizer

// EXCEEDING REQUIREMENTS:
// To exceed requirements for this assignment, I was thinking about the problems that many
// people face when they try to memorize a scripture or other things in general.
// One problem that I thought about is losing track of how many words have we memorized.
// For this assignment, I decided to add a "word counter" to add the words the user has memorized.
// First I made a variable called totalWordsMemorized and set it to 0.
// Later on I called this variable in the if (userSelect == "").
// Inside this if statement, I called the variable 3x in order to add the words that turns into an underscore
// when the user presses "enter". So every time the user presses enter, the totalWordsMemorized will add 3 until
// the program ends. At the end of the program, I would let the user know how many words has he/she memorized.


using System;
using System.Collections.Generic;

class Program
{

    // static int totalScripturesMemorized = 0;
    // int memory = totalScripturesMemorized + 3;

    static void Main(string[] args)
    {
        int totalWordsMemorized = 0;

        // Display the book, chapter, and verses
        Reference reference = new Reference("Proverbs", "3", "5", "6");
        Console.WriteLine(reference.DisplayScripture());
 
        // Display the verse / text
        Scripture scripture = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding." + " " + "In all thy ways acknowledge him, and he shall direct thy paths.", reference);
        scripture.Display();

        // Make a variable for the user input
        string userSelect = "";

        // Begin code by asking user what to do
        while (userSelect != "quit")
        {
            Console.WriteLine("Please press ENTER or type 'quit' to end the program: ");
            Console.WriteLine("Once you're finished, end the program to see how many words you memorized.");
            userSelect = Console.ReadLine();
            
            // If the user presses "enter"
            if (userSelect == "") 
            {
                Console.Clear();
                scripture.HideWords();
                totalWordsMemorized++;
                scripture.HideWords();
                totalWordsMemorized++;
                scripture.HideWords();
                totalWordsMemorized++;
                scripture.Display();
                
            }

            // if the user types the word "quit"
            else if (userSelect.ToLower() == "quit")
            {
                break;
            }

            // If the user types other words or letters instead of "quit"
            else if (userSelect != "quit")
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
        // Let the user know how many words has been memorized and say good bye
        Console.WriteLine();
        Console.WriteLine("Total words memorized: " + totalWordsMemorized);
        Console.WriteLine("Thank you for choosing Scripture Memorizer! Good-bye!");
    }
}