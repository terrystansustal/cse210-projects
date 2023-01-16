// Terrystan N. Sustal - Lesson 2

using System;

// The class of the program is titled Job
public class Job {
    // Member variables or attributes starts with an underscore _
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // Methods to display the class
    public void DisplayJobDetails() {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}") ;
    }
}