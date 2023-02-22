using System;

public class Reflection : Activity
{
    public Reflection(string name, string description) : base(name, description)
    {
        name = "";
        description = "";
    }

    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
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

    private List<int> _availableIndex = new List<int>();

    public List<int> PopulateIndexes()
    {
        for (int i = 0; i < _questions.Count; i++)
        {
            _availableIndex.Add(i);
        }
        return _availableIndex;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: \n");
        Random rnd = new Random();
        int randPrompt = rnd.Next(0,_prompts.Count);
        Console.WriteLine($"--- {_prompts[randPrompt]} ---\n");
    }

    public void Instructions()
    {
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related this experience.");
    }

    public void DisplayQuestions()
    {
        Random rnd = new Random();
        int rndindex = rnd.Next(_availableIndex.Count);
        int index = _availableIndex[rndindex];

        Console.Write($"> {_questions[index]} ");
        _availableIndex.RemoveAt(rndindex);
    }
}