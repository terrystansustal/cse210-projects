// Terrystan N. Sustal | Unit 05 Develop: Eternal Quest Program
// CSE 210: Programming with Classes

// Exceeding Requirements:
// To exceed requirements for this assignment I was thinking about things we can improve on in this life.
// We have many weaknesses or bad habits. So I decided to add another derived class called Improvement Goal.
// For this specific derived class, it will help the users to improve on their weaknesses or get rid of their
// bad habits by setting goals to accomplish it. I believe this will help the users to improve as a person
// by keeping track of their personal improvement.

using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
                
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;

        // Have the menu in a while loop until the user decides to quit(end the program)
        while(true)
        {

            // This is the main menu of the program. The user will have an option to select
            // from 1 - 6.
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();

            Console.WriteLine("Main Options:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

            // Convert the string into an integer
            Console.Write("Select a choice from the menu: ");
            int userSelect = int.Parse(Console.ReadLine());

            // If / else if statements for user options
            if (userSelect == 1)
            {
                // Select a goal type
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("4. Improvement Goal");
                Console.WriteLine();

                // Ask the users for what type of goal do they want to create
                Console.WriteLine("What type of goal would you like to create? ");
                int userSelectGoal = int.Parse(Console.ReadLine()); // Converts string into an integer
                Console.WriteLine();

                if (userSelectGoal == 1) // Option 1 = Simple Goal
                {
                    // Call in default constructor from the Simple Goal
                    SimpleGoal g1 = new SimpleGoal();
                    goals.Add(g1);

                }

                else if (userSelectGoal == 2) // Option 2 = Eternal Goal
                {
                    // Call in the default constructor from Eternal Goal
                    EternalGoal g2 = new EternalGoal();
                    goals.Add(g2);
                }
                else if (userSelectGoal == 3) // Option 1 = Checklist Goal
                {
                    // Call in default constructor from the Checklist Goal
                    ChecklistGoal g3 = new ChecklistGoal();
                    goals.Add(g3);
                }

                else if (userSelectGoal == 4) // Option 4 = Improvement Goal
                {
                    // Call in default constructor from the Improvement Goal
                    ImprovementGoal g4 = new ImprovementGoal();
                    goals.Add(g4);
                }
            }

            else if (userSelect == 2) // Option 2 = displays the list of goals
            {
                foreach (Goal goal in goals)
                {
                    if (goal is ChecklistGoal checklistGoal)
                    {
                    Console.WriteLine($"[{goal.GetIsCompleteChar()}] {goal.GetGoalName()} ({goal.GetGoalDescription()}) -- Currently Completed: {checklistGoal.GetComplete()}/{checklistGoal.GetNumOfTimesRequired()}");
                    }
                    else
                    {
                        Console.WriteLine($"[{goal.GetIsCompleteChar()}] {goal.GetGoalName()} ({goal.GetGoalDescription()})");
                    }
                }
            }

            //  Option 3 = Saves the goal
            else if (userSelect == 3)
            {
                // Save goals
                SaveAndLoad save = new SaveAndLoad();
                save.SaveFile(goals, totalPoints);
                Console.WriteLine("The file has been saved");
                Console.WriteLine();
            }

            // Option 4 = Loads the goal / file
            else if (userSelect == 4)
            {
                // Load goals / file
                SaveAndLoad load = new SaveAndLoad();
                load.LoadFile(goals, out totalPoints);
            }

            // Option 5 = Record an event when the user accomplishes the goal
            else if (userSelect == 5)
            {
                List<Goal> temp = new List<Goal>(); // Add a temporary goal list
                int counter = 1; // Syntax will start at 1
                foreach (Goal goal in goals)
                {
                    if (!goal.GetIsComplete()){
                        temp.Add(goal);
                        Console.WriteLine($"{counter}) {goal.GetGoalName()}");
                        counter++;
                    }
                }
                Console.WriteLine("Which goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine());
                totalPoints += temp[index - 1].RecordEvent();

                // totalPoints = Goal.RecordEvent(totalPoints);
                Console.WriteLine($"You now have {totalPoints} points");
            }

            // Option 6 = ends the program
            else if (userSelect == 6)
            {
                Console.WriteLine();
                Console.WriteLine("Thanks for your time, till next time! Good-bye!");
                Console.WriteLine();
                Environment.Exit(0);
            }

            // If user types an invalid number, show this print statement
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input please try again.");
            }
        }
    }
}