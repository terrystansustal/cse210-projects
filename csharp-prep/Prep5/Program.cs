// Terrystan N. Sustal - Prep 5

using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int number = SquareNumber(userNumber);

        DisplayResult(userName, number);
    }

    // This function will welcome the user to the program
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine();
    }

    // This functiom will ask the users for their name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // This function will ask the users for their favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();
        int number = int.Parse(favoriteNumber);

        // or
        // Console.Write("Please enter your favorite number: ");
        // int number = int.Parse(Console.ReadLine());

        return number;
    }

    // This function is a math formula to find the square
    static int SquareNumber(int number)
    {
        int squareNum = number * number;

        return squareNum;
    }

    // This function will display the results once called in the main function
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine();
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}