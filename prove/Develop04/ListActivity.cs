using System;

public class ListActivity : Activity
{
    private string[] _listPrompt = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructor
    public ListActivity()
    {
        _activityName = "Listing Activity!";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    // Method

    public void DisplayListPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        // Use the random method is select a random prompt in _listPrompt
        var random = new Random();
        string prompt = _listPrompt[random.Next(0, _listPrompt.Length)];

        // Make a variable to add all total items from user's input
        int totalItems = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationDesired);

        Console.WriteLine(prompt);
        
        // While start time is less than end time, run the loop
        // Readline allows the user to type his/her thoughts
        while (startTime < endTime)
        {
            Console.ReadLine();
            startTime = DateTime.Now;

            totalItems++;
        }

        // Show the user the total items
        Console.WriteLine();
        Console.WriteLine($"You listed {totalItems} items!");
    }

    // This display method will run the code for ListActivity
    public void DisplayListActivity()
    {
        DisplayStartMessage();
        DisplayGetReady();
        Console.WriteLine();
        DisplayAnimation();
        DisplayListPrompt();
        DisplayEndMessage();
    }
}