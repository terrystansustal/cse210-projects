using System;

// The Reception class will be a derived class (child)
public class Reception : Event
{
    // Attributes for the Reception Class
    protected string _rsvpEmail;

    // Constructors
    public Reception()
    {
        _eventType = "Reception";
        _eventTitle = "Wedding of John and Kate";
        _eventDescription = "He will dance";
        _rsvpEmail = "reservespot@fakersvp.com";
        _date = "January 05, 2023";
        _time = "3:00PM";
        _address = "Fake Haha USA";
    }

    public Reception (string eventTitle, string eventDescription, string date, string time, string address, string rsvpEmail) : base (eventTitle, eventDescription, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    
    // Methods
    public void DisplayFullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine(($"Event Title: {_eventTitle}"));
        Console.WriteLine($"Description: {_eventDescription}");
        Console.WriteLine($"Give us an email to reserve your spot! Email: {_rsvpEmail}");
        Console.WriteLine($"Date and time: {_date} - {_time}");
        Console.WriteLine($"Address: {_address}");
    }

    public void DisplayReception()
    {
        DisplayStandardDetails();
        Console.WriteLine();
        DisplayFullDetails();
        Console.WriteLine();
        DisplayShortDetails();
    }
    
}