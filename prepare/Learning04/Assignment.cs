using System;

public class Assignment
{   
    // Attrtibutes
    private string _studentName;
    private string _topic;

    // Constructors
    
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Set getters to use private variables for child classes and outside the code
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}