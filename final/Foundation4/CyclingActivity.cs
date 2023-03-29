using System;

public class CyclingActivity : Activity
{
    // Set Attributes
    private double _speed;

    // Set Constructors
    public CyclingActivity(string activityType, string date, int minutes, double distance, double speed) : base (activityType, date, minutes, distance)
    {
        _speed = speed;
    }

    // Set Getters

    public double GetSpeed()
    {   
        // _speed = 20;
        return _speed;
    }

    public override double CalculateSpeed()
    {
        double speed = 60 / CalculatePace();
        return speed;
    }

    public override double CalculatePace()
    {
        double pace = 60.0 / GetSpeed();
        return pace;
    }

    // Set Method

    public void DisplayCyclingActivity()
    {
        Console.WriteLine(GetSummary());
    }
}