using System;

public class Comment
{
    // Attributes for the comment class
    public string _userName = "";
    public string _userComment = "";

    // Method
    public void DisplayComments() {
        Console.WriteLine($"{_userName}: {_userComment}");
    }
}