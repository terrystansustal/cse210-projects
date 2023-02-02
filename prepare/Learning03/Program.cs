using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances and call the methods
        Console.WriteLine();
        Console.WriteLine("Here are the fractions and decimals:");
        Console.WriteLine();
       Fractions f1 = new Fractions();
       Console.WriteLine(f1.GetFractionString());
       Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine();
       Fractions f2 = new Fractions(5);
       Console.WriteLine(f2.GetFractionString());
       Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine();
       Fractions f3 = new Fractions(3, 4);
       Console.WriteLine(f3.GetFractionString());
       Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine();
       Fractions f4 = new Fractions(1, 3);
       Console.WriteLine(f4.GetFractionString());
       Console.WriteLine(f4.GetDecimalValue());
       Console.WriteLine();

    }
}