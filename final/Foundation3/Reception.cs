using System;

// The Reception class will be a derived class (child)
public class Reception : Event
{
    // Attributes for the Reception Class
    protected string _rsvpEmail;

    // Constructors
    public Reception (string eventType, string eventTitle, string eventDescription, string date, string time, string address, string rsvpEmail) : base (eventType, eventTitle, eventDescription, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Set up the Getters
    public string GetRSVPEmail()
    {
        return _rsvpEmail;
    }
    
    // Methods
    public void DisplayFullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"Event Type: {GetEventType()}");
        Console.WriteLine(($"Event Title: {GetEventTitle()}"));
        Console.WriteLine($"Description: {GetEventDescription()}");
        Console.WriteLine($"Give us an email to reserve your spot! Email: {GetRSVPEmail()}");
        Console.WriteLine($"Date and time: {GetDate()} - {GetTime()}");
        Console.WriteLine($"Address: {GetAddress()}");
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