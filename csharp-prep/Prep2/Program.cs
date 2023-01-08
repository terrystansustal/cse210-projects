using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Please enter your grade percentage: ");
        string userGrade = Console.ReadLine();
        int number = int.Parse(userGrade);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }

        else if (number >= 80)
        {
            letter = "B";
        }

        else if (number >= 70)
        {
            letter = "C";
        }

        else if (number >= 60)
        {
            letter = "D";
        }

        else{
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (number >= 70)
        {
            Console.WriteLine("You have passed the class!");
        }

        else
        {
            Console.WriteLine("Please try again and good luck!");
        }

        // Console.Write("Please enter your grade: ");
        // string userGrade = Console.ReadLine();
        // int number = int.Parse(userGrade);

        // if (number >= 90)
        // {
        //     Console.WriteLine("You have an A.");

        //     if (number >= 90)
        //     {
        //         Console.WriteLine("You passed the class");
        //     }
        // }

        // else if (number >= 80)
        // {
        //     Console.WriteLine("You have a B.");

        //     if (number >= 80)
        //     {
        //         Console.WriteLine("You passed the class");
        //     }
        // }

        // else if (number >= 70)
        // {
        //     Console.WriteLine("You have a C.");

        //     if (number >= 70)
        //     {
        //         Console.WriteLine("You passed the class");
        //     }
        // }

        // else if (number >= 60)
        // {
        //     Console.WriteLine("You have a D.");

        //     if (number >= 60)
        //     {
        //         Console.WriteLine("You have failed the class, please enroll again next semester to improve for a passing grade.");
        //     }
        // }

        // else
        // {
        //     Console.WriteLine("You have an F.");
        //     Console.WriteLine("You have failed the class, please enroll again next semester to improve for a passing grade.");
        // }
    }
}