using System;

// The OutdoorGathering class will be a derived class (child)
public class OutdoorGathering : Event
{
    // Attributes for the OutdoorGathering Class
    protected string _weather;

    // Constructors
    public OutdoorGathering()
    {
        _eventType = "Outdoor Gathering";
        _eventTitle = "Web Dev - Network";
        _eventDescription = "He will code";
        _weather = "sunny";
        _date = "January 05, 2023";
        _time = "3:00PM";
        _address = "Fake Haha USA";
    }

    public OutdoorGathering (string eventTitle, string eventDescription, string date, string time, string address, string weather) : base (eventTitle, eventDescription, date, time, address)
    {
        _weather = weather;
    }

    // Methods
    public void DisplayFullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine(($"Event Title: {_eventTitle}"));
        Console.WriteLine($"Description: {_eventDescription}");
        Console.WriteLine($"Date and time: {_date} - {_time}");
        Console.WriteLine($"It will be {_weather} during the event.");
        Console.WriteLine($"Address: {_address}");
    }

    public void DisplayOutdoorGathering()
    {
        DisplayStandardDetails();
        Console.WriteLine();
        DisplayFullDetails();
        Console.WriteLine();
        DisplayShortDetails();
    }
}