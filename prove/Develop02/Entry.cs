using System;
using System.IO;

// Class is Entry
public class Entry {

    // Variables for the class
    public string _date;
    public string _promptQuestion;
    public string _userResponse;

    public string _userGoal;

    // Method to display the class
    // For example: "01/20/2023 - What did I do today?
    //               I went to play basketball"
    
    public void DisplayEntry() {
        Console.WriteLine();
        Console.WriteLine($"{_date} - {_promptQuestion}: \n {_userResponse}");
    }

    public void DisplayGoal()
    {
        Console.WriteLine($"{_userGoal}");
    }
}