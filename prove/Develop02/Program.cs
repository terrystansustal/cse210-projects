using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        // Open the Journal.cs Class and set it to a currentJournal variable
        Journal currentJournal = new Journal();
        string start = "y";

        // Create instances for promptForUser
        // Add the promptForUser in the _prompt List
        Prompt promptForUser = new Prompt();
        promptForUser._prompt.Add(promptForUser._prompt1);
        promptForUser._prompt.Add(promptForUser._prompt2);
        promptForUser._prompt.Add(promptForUser._prompt3);
        promptForUser._prompt.Add(promptForUser._prompt4);
        promptForUser._prompt.Add(promptForUser._prompt5);
        promptForUser._prompt.Add(promptForUser._prompt6);
        promptForUser._prompt.Add(promptForUser._prompt7);
        promptForUser._prompt.Add(promptForUser._prompt8);

        // promptForUser.DisplayPrompt();
        // Console.WriteLine(promptForUser.DisplayPrompt());

        Console.WriteLine();
        Console.WriteLine("Welcome to your Personal Journal!");
        Console.Write("Would you like to continue to the main menu? Y/N: ");
        Console.ReadLine();

        if (start.ToUpper() == "Y")
        {
            int userSelection = 0;

            while (userSelection != 6)
            {
                Console.WriteLine();
                Console.WriteLine("Please select of one of the following choices: ");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Goals");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Save");
                Console.WriteLine("6. Quit");
                userSelection = int.Parse(Console.ReadLine());
                
                if (userSelection == 1)
                {
                    Entry currentEntry = new Entry();

                    // Get the current date of the day
                    DateTime theCurrentTime = DateTime.Now;
                    currentEntry._date = theCurrentTime.ToShortDateString();

                    // Display the prompt for the user to answer
                    currentEntry._promptQuestion = promptForUser.DisplayPrompt();
                    Console.WriteLine(currentEntry._promptQuestion);

                    // User response
                    currentEntry._userResponse = Console.ReadLine();

                    currentJournal._entries.Add(currentEntry);
                }

                else if (userSelection == 2)
                {
                    Entry currentGoal = new Entry();

                    // DateTime theCurrentTime = DateTime.Now;
                    // currentGoal._date = theCurrentTime.ToShortDateString();

                    Console.WriteLine("What are your goals for today? (ex: My goals for today (1/1/23) are...)");

                    currentGoal._userGoal = Console.ReadLine();

                    currentJournal._entries.Add(currentGoal);
    
                }

                else if (userSelection == 3)
                {
                    currentJournal.DisplayJournal();
                }

                else if (userSelection == 4)
                {
                    currentJournal = new Journal();
                    Console.Write("Which file would you like the open? ");
                    currentJournal._fileName = Console.ReadLine();
                    currentJournal.LoadFile();
                }

                else if (userSelection == 5)
                {
                    currentJournal.SaveFile();
                    Console.WriteLine("The file has been saved");
                    Console.WriteLine();
                }
            }
        }

        else
        {
            Console.WriteLine("You are now closing the Journal. Goodbye.");
            System.Environment.Exit(1);
        }
    }
}