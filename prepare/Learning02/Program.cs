// Terrystan N. Sustal - Lesson 2

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances for job1
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create instances for job2
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Front End Web Developer";
        job2._startYear = 2015;
        job2._endYear = 2019;

        // Display the instances for job1 and job 2
        // by calling the methods. This code is commented out because resume1.DisplayResume();
        // will print everything all at once

        // Console.WriteLine();
        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();
        // Console.WriteLine();

        // Create instances for resume1
        Resume resume1 = new Resume();
        resume1._fullName = "James Abella";

        // Add the jobs in the _jobs list
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Call the method DisplayResume from Resume.cs
        // to print the outcome
        Console.WriteLine();
        resume1.DisplayResume();
        Console.WriteLine();
    }
}