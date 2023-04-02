using System;
using System.Collections.Generic;


public class Video
{
    // Attributes for the video class
    public string _author;
    public string _title;
    public string _length;
    public List<Comment> _comments = new List<Comment>();

    // Method
    public void DisplayVideoInfo() {
        
        Console.WriteLine($"Video title: {_title}");
        Console.WriteLine($"Video by: {_author}");
        Console.WriteLine($"Length of the video: {_length}");
        Console.WriteLine();

        Console.WriteLine("Comments below:");

        foreach (Comment Comment in _comments) { // For each comment in comments
            Comment.DisplayComments();
        }
    }
}