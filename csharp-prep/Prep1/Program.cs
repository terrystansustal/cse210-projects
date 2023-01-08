using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their first name
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        
        // Ask the user for their last name
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        // Print the output of the code to see on the terminal
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}