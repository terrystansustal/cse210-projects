using System;

public class SwimmingActivity : Activity
{
    // Set Attributes
    private int _numOfLaps;

    // Set Constructors
    public SwimmingActivity(string activityType, string date, int minutes, double distance, int numOfLaps) : base (activityType, date, minutes, distance)
    {
        _numOfLaps = numOfLaps;
    }

    // Set Getters

    public int GetNumOfLaps()
    {   
        // _numOfLaps = 20;
        return _numOfLaps;
    }

    public override double GetDistance()
    {
        double numOfLaps = _numOfLaps * 50 / 1000;
        return numOfLaps;
    }

    public override double CalculateSpeed()
    {
        return GetDistance() / GetMinutes() * 60;
    }

    public override double CalculatePace()
    {
        double pace = GetMinutes() / GetDistance() * 60;
        return pace;
    }

    // Set Method

    public void DisplaySwimmingActivity()
    {
        Console.WriteLine(GetSummary());
    }
}