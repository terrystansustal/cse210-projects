using System;

// The Event Class will be the base class (parent)
public class Event
{
    // Attributes for the base class
    private string _eventType;
    private string _eventTitle;
    private string _eventDescription;
    private string _date;
    private string _time;
    private string _address;

    // Set Constructors for the base class
    public Event ()
    {
    }

    public Event (string eventType, string eventTitle, string eventDescription, string date, string time, string address)
    {   
        _eventType = eventTitle;
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _date = date;
        _time = time;
        _address = address;
    }

    // Set Getters
    public string GetEventType()
    {
        return _eventType;
    }
    
    public string GetEventTitle()
    {
        return _eventTitle;
    }
    public string GetEventDescription()
    {
        return _eventDescription;
    }

    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public string GetAddress()
    {
        return _address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(($"Event Title: {GetEventTitle()}"));
        Console.WriteLine($"Description: {GetEventDescription()}");
        Console.WriteLine($"Date and time: {GetDate()} - {GetTime()}");
        Console.WriteLine($"Address: {GetAddress()}");
    }

    public void DisplayShortDetails()
    {
        Console.WriteLine("Short Details:");
        Console.WriteLine($"Event Type: {GetEventType()}");
        Console.WriteLine($"Title: {GetEventTitle()}");
        Console.WriteLine($"Date: {GetDate()}");
    }
}