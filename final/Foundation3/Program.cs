// Terrystan N. Sustal
// Final Project - Program 3

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances for the events
        Lecture event1 = new Lecture("Lecture", "Ted Talks", "Bill Gates will give an inspirational talk about how he worked hard to be where he's at today.", "March 30, 2023", "6:00PM", "Fake Address 123 Daly City, CA. 94014", "Bill Gates", 100);
        Reception event2 = new Reception("Reception", "Wedding of John and Kate", "Congratulations John and Kate for getting married for time and eternity!", "May 05, 2023", "10:00AM", "47770 Lincoln Ave, Oakland, CA. 94602", "reservespot@fakersvp.com");
        OutdoorGathering event3 = new OutdoorGathering("Outdoor Gathering", "Web Dev - Network", "Come and join us to grow your network in the tech industry!", "January 05, 2023", "3:00PM", "NotRealAddress 321 Park SF, CA. 01123", "very cloudy");

        // Call the methods from the instances that was created
        event1.DisplayLecture();
        Console.WriteLine();
        Console.WriteLine("------------------------");
        Console.WriteLine();

        event2.DisplayReception();
        Console.WriteLine();
        Console.WriteLine("------------------------");
        Console.WriteLine();

        event3.DisplayOutdoorGathering();
        Console.WriteLine();

    }
}