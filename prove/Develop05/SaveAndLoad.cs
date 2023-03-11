using System;
using System.IO; 

// This is the SaveAndLoad class

public class SaveAndLoad
{
    // Set attributes for the base class
    protected string _fileName;

    // Make a protected list to hold the goal type, goal name, goal description and goal points


    // Method to save the file
    public void SaveFile(List<Goal> goals, int totalPoints)
    {
        Console.Write("What would you like to name this file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName, append:false))
        {
            outputFile.WriteLine($"{totalPoints}");

            foreach (Goal goal in goals)
            {
                
                if (goal is SimpleGoal)
                {
                    outputFile.WriteLine($"{goal.GetGoalType()}:{goal.GetGoalName()}|{goal.GetGoalDescription()}|{goal.GetGoalPoints()}|{goal.GetIsComplete().ToString().ToLower()}");
                }

                else if (goal is EternalGoal)
                {
                    EternalGoal eternalGoal = (EternalGoal)goal;
                    outputFile.WriteLine($"{goal.GetGoalType()}:{goal.GetGoalName()}|{goal.GetGoalDescription()}|{goal.GetGoalPoints()}|{eternalGoal.GetNumOfTimes()}");
                }

                else if (goal is ChecklistGoal)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    outputFile.WriteLine($"{goal.GetGoalType()}:{goal.GetGoalName()}|{goal.GetGoalDescription()}|{goal.GetGoalPoints()}|{checklistGoal.GetGoalBonus()}|{checklistGoal.GetComplete()}|{checklistGoal.GetNumOfTimesRequired()}");
                }

                else if (goal is ImprovementGoal)
                {
                    outputFile.WriteLine($"{goal.GetGoalType()}:{goal.GetGoalName()}|{goal.GetGoalDescription()}|{goal.GetGoalPoints()}|{goal.GetIsComplete().ToString().ToLower()}");
                }
            }
        }
    }

    public void LoadFile(List<Goal> goalss, out int totalPoints)
    {
        Console.Write("Which file would you like to open? ");
        _fileName = Console.ReadLine();

        string[] goals = System.IO.File.ReadAllLines(_fileName);

        totalPoints = int.Parse(goals[0]);

        foreach (string goal in goals)
        {
            string[] parts = goal.Split(":"); // Split the first half with a colon (":")
            if (parts[0] == "Simple Goal") // Have an if statement for simple goal to be specific with goal type
            {
                string[] lines = parts[1].Split("|"); // Split the second hald with a ("|")
                SimpleGoal simple = new SimpleGoal(lines[0], lines[1], int.Parse(lines[2]), bool.Parse(lines[3]));
                goalss.Add(simple);
            }

            else if (parts[0] == "Eternal Goal") // Have an if statement for simple goal to be specific with goal type
            {
                string[] lines = parts[1].Split("|"); // Split the second hald with a ("|")
                EternalGoal eternal = new EternalGoal(lines[0], lines[1], int.Parse(lines[2]), int.Parse(lines[3]));
                goalss.Add(eternal);
            }

            else if (parts[0] == "Checklist Goal") // Have an if statement for simple goal to be specific with goal type
            {
                string[] lines = parts[1].Split("|"); // Split the second hald with a ("|")
                ChecklistGoal checklist = new ChecklistGoal(lines[0], lines[1], int.Parse(lines[2]), int.Parse(lines[3]), int.Parse(lines[4]), int.Parse(lines[5]));
                goalss.Add(checklist);
            }

            else if (parts[0] == "Improvement Goal") // Have an if statement for improvement goal to be specific with goal type
            {
                string[] lines = parts[1].Split("|"); // Split the second hald with a ("|")
                ImprovementGoal improve = new ImprovementGoal(lines[0], lines[1], int.Parse(lines[2]), bool.Parse(lines[3]));
                goalss.Add(improve);
            }
        }
    }
}