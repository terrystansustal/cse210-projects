// Terrystan N. Sustal - Lesson 2

using System;

// The class name is Resume
public class Resume {

    // Variable for person's fullname
    public string _fullName = "";

    // Initialize list into a new list before using it
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume() {
        Console.WriteLine($"Name: {_fullName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs) {
            job.DisplayJobDetails();
        }
    }
}