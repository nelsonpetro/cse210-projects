using System;

public class Prompts
{
    List<int> _listNumbers = new List<int>(); 
    public string DisplayPrompts()
    {   
        string _prompt = "";
        List<string> _prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What is the most interesting thing I did today?",
            "Who is the most helpful person I came across today?",
            "What blessings did I receive today?",
            "What was the best part of my day?",
            "What could I have been done better today?",
            "Did I see something different today? What was that?",
            "What will I do tomorrow that I did not do today and how will I do it?"
        };
        Random rand = new Random();  
        int number = rand.Next(0, _prompts.Count);

        if (_listNumbers.Count() < 8)
        {
            if (!_listNumbers.Contains(number))
            {
                Console.WriteLine($"{number + 1}. {_prompts[number]}");
                _listNumbers.Add(number);
                _prompt = _prompts[number];
            }
            else
            {
                DisplayPrompts();
            }
        }
        else
        {
            Console.Write("There are nor more prompts for today!");
        }
        return _prompt;
    } 
}