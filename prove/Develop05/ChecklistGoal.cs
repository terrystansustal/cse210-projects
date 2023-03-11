using System;
using System.IO; 

// This is the ChecklistGoal derived class
// Inherit from the Goal base class

public class ChecklistGoal : Goal 
{
    // Attributes
    protected int _numOfTimesRequired;
    protected int _complete;
    protected int _numOfTimesCompleted;
    protected int _goalBonus;

    // Constructor
    public ChecklistGoal()
    {
        _goalType = "Checklist Goal";
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _numOfTimesRequired = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _goalBonus = int.Parse(Console.ReadLine());
    }

    public ChecklistGoal (string goalName, string goalDescription, int goalPoints, int goalBonus, int complete, int numOfTimesRequired) : base(goalName, goalDescription, goalPoints)
    {
        _goalType = "Checklist Goal";
        _numOfTimesRequired = numOfTimesRequired;
        _numOfTimesCompleted = complete;
        _goalBonus = goalBonus;
    }

    // Getters for ChecklistGoal class
    public int GetNumOfTimesRequired()
    {
        return _numOfTimesRequired;
    }

    public int GetComplete()
    {
        return _numOfTimesCompleted;
    }

    public int GetGoalBonus()
    {
        return _goalBonus;
    }

    // Methods

    public override int RecordEvent()
    {
        _numOfTimesCompleted++;

        // Award the user to get points
        // points depends on goals
        if (_numOfTimesCompleted >= _numOfTimesRequired){
            _isComplete = true;
            // totalPoints += _goalPoints;
        }

        Console.WriteLine($"Congratulations, you have completed this goal {_numOfTimesCompleted} times!");
        Console.WriteLine();
        Console.WriteLine($"You have earned {_goalPoints}");
        Console.WriteLine();
        return _goalPoints;
    }
}