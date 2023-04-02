// Terrystan N. Sustal
// Final Project - Program 1

using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the videos and comments
        List<Video> videos = new List<Video>();
        // Create instances for video 1
        Video v1 = new Video();
        v1._title = "How to Cook Fried Chicken";
        v1._author = "Chef Davd TV";
        v1._length = "4:27 minutes";

        // Create instances for video 2
        Video v2 = new Video();
        v2._title = "Resident Evil 4 Remake | Gameplay";
        v2._author = "AttendedStan";
        v2._length = "45:00 minutes";

        // Create instances for video 3
        Video v3 = new Video();
        v3._title = "Funny Gender Reveal Compilation";
        v3._author = "Funny Monster";
        v3._length = "10:11 minutes";

        // Create instances for video 4
        Video v4 = new Video();
        v4._title = "A man SAVES a dog!";
        v4._author = "FakeNews Network";
        v4._length = "3:30 minutes";

        // Create instances for comments on How to Cook Fried Chicken
        Comment v1c1 = new Comment();
        v1c1._userName = "Jack King";
        v1c1._userComment = "This is a great tutorial! Well explained and quick to the point!";
        
        Comment v1c2 = new Comment();
        v1c2._userName = "Harry Whitmer";
        v1c2._userComment = "Thanks for the video! Now I know how to cook fried chicken for my family!";

        Comment v1c3 = new Comment();
        v1c3._userName = "James Whitaker";
        v1c3._userComment = "Wow this was a fast tutorial! Not just that but the recipe is very cheap and affordable!";

        // Create instances for comments on Resident Evil 4 Remake | Gameplay
        Comment v2c1 = new Comment();
        v2c1._userName = "Sarah Smith";
        v2c1._userComment = "Wow I love the remake! It's crazy to think the original game came out in 2005!";

        Comment v2c2 = new Comment();
        v2c2._userName = "Steve Garcia";
        v2c2._userComment = "The remake of this game brings back so many memories of my childhood!";

        Comment v2c3 = new Comment();
        v2c3._userName = "Thomas Miller";
        v2c3._userComment = "Thanks for this gameplay! I enjoyed watching it. I can't wait to get my hands on this game!";

        // Create instances for comments on Funny Gender Reveal Fail Compilation
        Comment v3c1 = new Comment();
        v3c1._userName = "Maricel Abella";
        v3c1._userComment = "Well, that's one way to make the gender reveal memorable!";

        Comment v3c2 = new Comment();
        v3c2._userName = "Myka Martinez";
        v3c2._userComment = "At least they got some great footage for the baby's future embarrassing home videos!";

        Comment v3c3 = new Comment();
        v3c3._userName = "Stan Williams";
        v3c3._userComment = "Who knew that a balloon could be so unpredictable?";

        Comment v3c4 = new Comment();
        v3c4._userName = "Karl Thompson";
        v3c4._userComment = "I guess it's time to return all those pink and blue decorations.";

        Comment v4c1 = new Comment();
        v4c1._userName = "Taylor Mahomes";
        v4c1._userComment = "Thank you sir for saving this dog. You are a hero!";

        Comment v4c2 = new Comment();
        v4c2._userName = "Jake Edwards";
        v4c2._userComment = "You deserve a medal!";

        Comment v4c3 = new Comment();
        v4c3._userName = "Logan Jones";
        v4c3._userComment = "Oh my! Thank goodness that man was there to save the dog from the fire!";

        // Add the video and comment to a list
        videos.Add(v1); // Add v1 to the videos list
        v1._comments.Add(v1c1); // Add v1c1 to the _comments list
        v1._comments.Add(v1c2); // Add v1c2 to the _comments list
        v1._comments.Add(v1c3); // Add v1c3 to the _comments list

        videos.Add(v2); // Add v2 to the videos list
        v2._comments.Add(v2c1); // Add v2c1 to the _comments list
        v2._comments.Add(v2c2); // Add v2c2 to the _comments list
        v2._comments.Add(v2c3); // Add v2c3 to the _comments list

        videos.Add(v3); // Add v3 to the videos list
        v3._comments.Add(v3c1); // Add v3c1 to the _comments list
        v3._comments.Add(v3c2); // Add v3c2 to the _comments list
        v3._comments.Add(v3c3); // Add v3c3 to the _comments list
        v3._comments.Add(v3c4); // Add v3c4 to the _comments list

        videos.Add(v4); // Add v3 to the videos list
        v4._comments.Add(v4c1); // Add v4c1 to the _comments list
        v4._comments.Add(v4c2); // Add v4c2 to the _comments list
        v4._comments.Add(v4c3); // Add v4c3 to the _comments list


        // This will print for each video in videos list
        // It will iterate through each video and call the DisplayVideoInfo() method
        Console.WriteLine();
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }
    } 
}