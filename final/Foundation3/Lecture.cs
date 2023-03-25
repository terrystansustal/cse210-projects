using System;

// The Lecture class will be a derived class (child)
public class Lecture : Event
{
    // Attributes for the Lecture Class
    protected string _guestSpeaker;
    protected int _limitedCapacity;

    // Set up Constructors
    public Lecture ()
    {
        _eventType = "Lecture";
        _eventTitle = "TED Talks";
        _guestSpeaker = "Bill Gates";
        _eventDescription = "He will speak";
        _limitedCapacity = 100;
        _date = "March 30, 2023";
        _time = "6:00PM";
        _address = "Fake Address USA";

    }

    public Lecture (string eventTitle, string eventDescription, string date, string time, string address, string guestSpeaker, int limitedCapacity) : base (eventTitle, eventDescription, date, time, address)
    {
        _guestSpeaker = guestSpeaker;
        _limitedCapacity = limitedCapacity;
    }

    // Set up methods for Lecture Class
    public void DisplayFullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine(($"Event Title: {_eventTitle}"));
        Console.WriteLine($"Guest Speaker: {_guestSpeaker}");
        Console.WriteLine($"Description: {_eventDescription}");
        Console.WriteLine($"Capacity: {_limitedCapacity}");
        Console.WriteLine($"Date and time: {_date} - {_time}");
        Console.WriteLine($"Address: {_address}");
    }

    public void DisplayLecture()
    {
        DisplayStandardDetails();
        Console.WriteLine();
        DisplayFullDetails();
        Console.WriteLine();
        DisplayShortDetails();
    }

}