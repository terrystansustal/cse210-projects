using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture event1 = new Lecture();
        Reception event2 = new Reception();
        OutdoorGathering event3 = new OutdoorGathering();

        event1.DisplayLecture();
        Console.WriteLine();
        Console.WriteLine("------------------------");

        event2.DisplayReception();
        Console.WriteLine();
        Console.WriteLine("------------------------");

        event3.DisplayOutdoorGathering();
    }
}