using System;

// The Activity Class will be the base
public class Activity 
{
    //                                      ----- Attributes/Variables -----

    // Make a variable for user input

    // Set private attributes for the base class
    protected string _activityName;
    protected string _description;
    protected int _durationDesired;

    // Set Constructors
    public Activity ()
    {
        // setduration
    }

    //                                      ----- Getters -----

    // Make GETTERS to use private attributes for derived classes and outside the code
    public string GetActivityName()
    {
        return _activityName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDurationDesired()
    {
        return _durationDesired;
    }

    //                                      ----- Setter -----

    // Make a SETTER for SetDuration and set the desired time for the activity
    // int.parse will convert the user's input into an int
    public int SetDuration()
    {
        Console.Write("How long, in seconds, would you like your session? ");
        int durationDesired = int.Parse(Console.ReadLine());

        _durationDesired = durationDesired;
        return _durationDesired;
    }

    //                                      ----- Methods for base class -----

    // Display the start message and call the SetDuration() Setter
    // So that it will all display at once
    public void DisplayStartMessage()
    {
        Console.WriteLine("");
        string startMessage = $"Welcome to the {_activityName}\n\n{_description}";
        Console.WriteLine(startMessage);
        Console.WriteLine();

        SetDuration();
    }

    public void DisplayGetReady()
    {
        Console.WriteLine();
        Console.WriteLine("Get ready...");
    }

    // Make a spinnerv animation while the program is on pause
    public void DisplayAnimation()
    {   
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!");
        DisplayAnimation();
        Console.WriteLine("");
        // int duration = SetDuration();
        Console.WriteLine($"You have completed another {_durationDesired} seconds of the {_activityName}");
    }
}