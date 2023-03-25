using System;

// The Event Class will be the base class (parent)
public class Event
{
    // Attributes for the base class
    protected string _eventType;
    protected string _eventTitle;
    protected string _eventDescription;
    protected string _date;
    protected string _time;
    protected string _address;

    // Set Constructors for the base class
    public Event ()
    {
    }

    public Event (string eventTitle, string eventDescription, string date, string time, string address)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(($"Event Title: {_eventTitle}"));
        Console.WriteLine($"Description: {_eventDescription}");
        Console.WriteLine($"Date and time: {_date} - {_time}");
        Console.WriteLine($"Address: {_address}");
    }

    public void DisplayShortDetails()
    {
        Console.WriteLine("Short Details:");
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Date: {_date}");
    }
}