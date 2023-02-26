using System;

public class ReflectionActivity : Activity
{
    // Make a variable for the user input
    string userSelects = "";

    // Add two attributes for this derived class
    // One for prompt and one for question

    private string[] _userPrompt =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _userQuestions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Constructors

    public ReflectionActivity()
    {
        _activityName = "Reflection Activity!";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    // Method
    public void DisplayRandomPrompt()
    {
        Console.WriteLine("Consider the following prompt:");

        var random = new Random();
        string prompt = _userPrompt[random.Next(0, _userPrompt.Length)];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationDesired);

        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press ENTER to continue.");
        userSelects = Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayRandomQuestion()
    {
        // var randomQuestion = new Random();
        // string question = _userQuestions[randomQuestion.Next(0, _userQuestions.Length)];

        // Console.Write($"> {question} ");
        // DisplayPonderAnimation();
        // Console.WriteLine();

        // Console.Write($"> {question} ");
        // DisplayPonderAnimation();

        var randomQuestion = new Random();
        int questionIndex1 = randomQuestion.Next(0, _userQuestions.Length);
        int questionIndex2 = randomQuestion.Next(0, _userQuestions.Length);

        while (questionIndex2 == questionIndex1);

        string question1 = _userQuestions[questionIndex1];
        string question2 = _userQuestions[questionIndex2];

        Console.WriteLine($"> {question1}");
        DisplayPonderAnimation();
        Console.WriteLine();

        Console.WriteLine($"> {question2}");
        DisplayPonderAnimation();
    }

    public void DisplayPonderAnimation()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationDesired / 2);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    // This display method will run the code for Reflection Activity
    public void DisplayReflectionAcitivity()
    {
        DisplayStartMessage();
        DisplayGetReady();
        DisplayAnimation();
        Console.WriteLine();
        DisplayRandomPrompt();
        Console.WriteLine();
        DisplayRandomQuestion();
        DisplayEndMessage();
    }
}