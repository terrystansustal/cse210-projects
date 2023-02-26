using System;

public class ImproveActivity : Activity
{
    private string[] _listPrompt = {
        "What are your short comings today? How can you improve to do better?",
        "Did you procastinate on your tasks today? If so, what can you do to be more productive?",
        "Did you offend anyone today? If so, how can you say sorry to them and rebuild your friendship with that person?"
    };

    // Constructor
    public ImproveActivity()
    {
        _activityName = "Improve Activity!";
        _description = "This activity will help you reflect on the short comings you had today by having you write down on how to improve in a desired time.";
    }

    // Method

    public void DisplayImprovePrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        // Use the random method is select a random prompt in _listPrompt
        var random = new Random();
        string prompt = _listPrompt[random.Next(0, _listPrompt.Length)];

        // Make a variable to add all total items from user's input
        int totalItems = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationDesired);

        Console.WriteLine();
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
        Console.WriteLine($"You listed {totalItems} items. You got this, we believe in you!");
    }

    // This display method will run the code for ListActivity
    public void DisplayImproveActivity()
    {
        DisplayStartMessage();
        DisplayGetReady();
        Console.WriteLine();
        DisplayAnimation();
        DisplayImprovePrompt();
        DisplayEndMessage();
    }
}