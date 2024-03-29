// Terrystan N. Sustal
// Final Project - Program 4

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Make a list and add all of the activities in order to iterate it later
        List<Activity> activities = new List<Activity>();

        // Create instances for the activities
        RunningActivity activity1 = new RunningActivity("Running", "March 25, 2023", 30, 3.0);
        CyclingActivity activity2 = new CyclingActivity("Cycling", "March 25, 2023", 30, 15, 20);
        SwimmingActivity activity3 = new SwimmingActivity("Swimming", "March 25, 2023", 30, 10, 60);;

        // Add the instances (activities) in the activity list
        activities.Add(activity1);
        activities.Add(activity2);
        activities.Add(activity3);

        Console.WriteLine();
        Console.WriteLine("Exercise Tracking:");
        Console.WriteLine();

        // Display each activity in the activity list
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}