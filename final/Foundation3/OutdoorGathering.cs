using System;

// The OutdoorGathering class will be a derived class (child)
public class OutdoorGathering : Event
{
    // Attributes for the OutdoorGathering Class
    protected string _weather;

    // Constructors

    public OutdoorGathering (string eventType, string eventTitle, string eventDescription, string date, string time, string address, string weather) : base (eventType, eventTitle, eventDescription, date, time, address)
    {
        _weather = weather;
    }

    // Set up the Getters
    public string GetWeather()
    {
        return _weather;
    }

    // Methods
    public void DisplayFullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"Event Type: {GetEventType()}");
        Console.WriteLine(($"Event Title: {GetEventTitle()}"));
        Console.WriteLine($"Description: {GetEventDescription()}");
        Console.WriteLine($"Date and time: {GetDate()} - {GetTime()}");
        Console.WriteLine($"It will be {GetWeather()} during the event.");
        Console.WriteLine($"Address: {GetAddress()}");
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