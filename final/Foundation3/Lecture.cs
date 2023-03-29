using System;

// The Lecture class will be a derived class (child)
public class Lecture : Event
{
    // Attributes for the Lecture Class
    protected string _guestSpeaker;
    protected int _limitedCapacity;

    // Set up Constructors
    public Lecture (string eventType, string eventTitle, string eventDescription, string date, string time, string address, string guestSpeaker, int limitedCapacity) : base (eventType, eventTitle, eventDescription, date, time, address)
    {
        _guestSpeaker = guestSpeaker;
        _limitedCapacity = limitedCapacity;
    }

    // Set up the Getters
    public string GetGuestSpeaker()
    {
        return _guestSpeaker;
    }

    public int GetLimitedCap()
    {
        return _limitedCapacity;
    }

    // Set up methods for Lecture Class
    public void DisplayFullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"Event Type: {GetEventType()}");
        Console.WriteLine(($"Event Title: {GetEventTitle()}"));
        Console.WriteLine($"Guest Speaker: {GetGuestSpeaker()}");
        Console.WriteLine($"Description: {GetEventDescription()}");
        Console.WriteLine($"Capacity: {GetLimitedCap()}");
        Console.WriteLine($"Date and time: {GetDate()} - {GetTime()}");
        Console.WriteLine($"Address: {GetAddress()}");
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