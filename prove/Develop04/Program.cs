// Terrystan N. Sustal | CSE 210 Programming With Classes
// Exceeding Requirements:
// For this activity, I was thinking what else I can do to show creativity.
// I thought about making short comings every day because of our weaknesses.
// I doubled checked the prompts or questions that the program provided and noticed
// that they didn't ask questions about weaknesses or mistakes.
// I decided to add a new derived class called ImproveActivity.
// The ImproveActivity is very similar to the ListActivity but this time
// the program asks user if he/she made a mistake today and how can he/she
// improve to do better. The user will then list a couple of things on how he/she
// can do better.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize
        // TESTING SECTION
        BreathingActivity a1 = new BreathingActivity();
        // a1.DisplayBreathingActivity();
        ReflectionActivity a2 = new ReflectionActivity();
        // a2.DisplayReflectionAcitivity();
        ListActivity a3 = new ListActivity();
        // a3.DisplayListActivity();
        ImproveActivity a4 = new ImproveActivity();

        

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Acitivity");
            Console.WriteLine("3. List Acitivity");
            Console.WriteLine("4. Improve Activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");
            int userSelect = int.Parse(Console.ReadLine());

            if (userSelect == 1)
            {
                a1.DisplayBreathingActivity(); 
            }

            else if (userSelect == 2)
            {
                a2.DisplayReflectionAcitivity();
            }

            else if (userSelect == 3)
            {
                a3.DisplayListActivity();
            }

            else if (userSelect == 4)
            {
                a4.DisplayImproveActivity();
            
            }

            else if (userSelect == 5)
            {   
                Console.WriteLine();
                Console.WriteLine("Thanks for your time, till next time! Good-bye!");
                Console.WriteLine();
                Environment.Exit(0);
            
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input please try again.");
            }

        }
    }
}