// Terrystan N. Sustal - Learning Activity | Prep 4

using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int userNumber = -1;

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Please enter a number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {    
                numbers.Add(userNumber);
            }
        }

            // Part 1
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine();
            Console.WriteLine($"The sum is {sum}");
            
            // Part 2
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average of the list is {average}");

            // Part 3
            // Look for the specific max number with index
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                max = number;
            }

            Console.WriteLine($"The max of the list is {max}");

            // Stretch Challenge 1
            // Look for the smallest positive number
            int min = numbers[0];

            foreach (int number in numbers)
            {
                if (number < min)
                min = number;
            }

            Console.WriteLine($"The smallest positive number is {min}");
            Console.WriteLine();

            

        
    }
}