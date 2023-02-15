using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        // Test GetSummary() method from Assignment.cs
        Assignment assignment = new Assignment("Terry Sustal", "Math");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();
        // Test GetHomeworkList() method from MathAssignment.cs
        MathAssignment assignment2 = new MathAssignment("Terry Sustal", "Math", "Section 7.3", "Problems 8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        Console.WriteLine();
        // Test GetWritingInformation() method from WritingAssignment.cs
        WritingAssignment assignment3 = new WritingAssignment("Terry Sustal", "European History", "The Cause of World War Two");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());

        Console.WriteLine();
    }
}