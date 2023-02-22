using System;

public class Listing : Activity
{
    private int _listedItems;

    private List<int> _availableIndex = new List<int>();

    private List<string> _listingQuestions = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing(string name, string description) : base (name, description)
    {
        name = "";
        description = "";
    }

    public List<int> PopulateIndexes()
    {
        for (int i = 0; i < _listingQuestions.Count; i++)
        {
            _availableIndex.Add(i);
        }
        return _availableIndex;
    }

    public void DisplayQuestions()
    {
        Random rnd = new Random();
        int rndindex = rnd.Next(_availableIndex.Count);
        int index = _availableIndex[rndindex];

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.Write($"--- {_listingQuestions[index]} ---");
        _availableIndex.RemoveAt(rndindex);
    }

    public int GetEntries()
    {
        DateTime start = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _listedItems++;
        }
        return _listedItems;
    }

    public void DisplayListedItems()
    {
        Console.WriteLine($"\nYou listed {_listedItems} items!\n");
    }
}