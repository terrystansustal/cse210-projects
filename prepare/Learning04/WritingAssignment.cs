using System;

public class WritingAssignment : Assignment
{
    // Attributes
    private string _title;

    // Constructors
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Make getters in order to use private variables
    public string GetTitle()
    {
        return _title;
    }

    public string GetWritingInformation()
    {
        return _title + " " + "by" + " " + GetStudentName();
    }
}