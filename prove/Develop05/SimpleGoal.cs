using System;
using System.IO; 

// This is the SimpleGoal derived class
// Inherit from the Goal base class

public class SimpleGoal : Goal 
{

    // Attributes

    // Constructor (inherit the constructor from Goal base class)
    public SimpleGoal()
    {
        _goalType = "Simple Goal";
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    public SimpleGoal (string goalName, string goalDescription, int goalPoints, bool complete) : base(goalName, goalDescription, goalPoints)
    {
        _goalType = "Simple Goal";
        _isComplete = complete;
    }

    // Override the methods from the Goal base class
    
    public override int RecordEvent()
    {

        // Award the user to get points and points depends on goals

        _isComplete = true;

        Console.WriteLine($"Congratulations you have earned {_goalPoints} points!");
        Console.WriteLine();
        // totalPoints += _goalPoints;
        return _goalPoints;
    }
}