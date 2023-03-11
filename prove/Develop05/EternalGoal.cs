using System;
using System.IO; 

// This is the EternalGoal derived class
// Inherit from the Goal base class

public class EternalGoal : Goal 
{
    // Attributes
    protected int _numOfTimes;

    // Constructor

    public EternalGoal()
    {
        _goalType = "Eternal Goal";
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    public EternalGoal (string goalName, string goalDescription, int goalPoints, int numOfTimes) : base(goalName, goalDescription, goalPoints)
    {
        _goalType = "Eternal Goal";
        _numOfTimes = numOfTimes;
    }

    // Getter
    public int GetNumOfTimes()
    {
        return _numOfTimes;
    }

    // Methods

    public override int RecordEvent()
    {
        _numOfTimes++;
        while(true)
        {
            _isComplete = true;

            Console.WriteLine($"Congratulations, you have completed this goal {_numOfTimes} times!");
            Console.WriteLine($"Congratulations you have earned {_goalPoints} points!");
            Console.WriteLine();
            // totalPoints += _goalPoints;
            return _goalPoints;
        }
    }
}