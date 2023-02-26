using System;

public class BreathingActivity : Activity
{
    // No need to make new attributes for this class

    // Constructors
    public BreathingActivity()
    {
        _activityName = "Breathing Activity!";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Method

    public void DisplayBreathing()
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDurationDesired());
        DateTime current = DateTime.Now;

        while (current < end)
        {
            Console.WriteLine("");
            Console.Write($"Breathe in...4");
            for (int i=3; i>-1; i=i-1)
            {
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write($"{i}");
            }

            Console.WriteLine("");
            Console.Write($"Breathe out...4");
            for (int i=3; i>-1; i=i-1)
            {
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write($"{i}");
            }

            current = DateTime.Now; // Reset current time
        }
    }

    // This display method will run the code for BreathingActivity
    public void DisplayBreathingActivity()
    {
        DisplayStartMessage();
        DisplayGetReady();
        DisplayAnimation();
        DisplayBreathing();
        Console.WriteLine();
        DisplayEndMessage();
    }
}