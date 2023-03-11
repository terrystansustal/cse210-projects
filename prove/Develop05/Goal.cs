using System;
using System.IO; 

// This is the base class

public class Goal 
{
    // Set attributes for the base class

    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected bool _isComplete = false;

    // Set constructors for the base class

    // This empty constructor will allow us to customize it for each derived class
    public Goal()
    {
    }

    // This constructor will load the content of the file
    public Goal (string goalName, string goalDescription, int goalPoints)
    {   
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;

    }

    // Getters
    public string GetGoalType()
    {
        return _goalType;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public int GetGoalPoints()
    {
        return _goalPoints;
    }

    public bool GetIsComplete(){
        return _isComplete;
    }

    // another method that retursn either X or ' '
    public char GetIsCompleteChar(){
        if (!_isComplete)
            return ' ';
        else
            return 'X';
    }

    // Setters
    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public void SetGoalDescription(string goalDescription)
    {
        _goalName = goalDescription;
    }

    public void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }

    // Set methods for the base class
    public virtual int RecordEvent()
    {
        return _goalPoints;
    }

}