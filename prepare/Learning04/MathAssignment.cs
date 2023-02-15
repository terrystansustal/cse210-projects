using System;

public class MathAssignment : Assignment
{
    // Attributes
    private string _textBookSection;
    private string _problems;

    // Create Constructors and use the base keyword to use constructors from parent class
    public MathAssignment (string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    // Set getters to access private attributes
    public string GetTextBookSection()
    {
        return _textBookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public string GetHomeworkList()
    {
        return _textBookSection + " " + _problems;
    }
}