using System;

public class RunningActivity : Activity
{
    // Set Attributes

    // Set Constructors
    public RunningActivity(string activityType, string date, int minutes, double distance) : base (activityType, date, minutes, distance)
    {
    }

    // Set virtual methods to override in derived classes

    public override double CalculateSpeed()
    {   
        double speed = GetDistance() / GetMinutes() * 60;
        return speed;
    }

    public override double CalculatePace()
    {
        double pace = GetMinutes() / GetDistance();
        return pace;
    }

    public void DisplayRunningActivity()
    {
        Console.WriteLine(GetSummary());
    }
}