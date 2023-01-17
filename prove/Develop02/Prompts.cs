using System;

public class Prompts
{
    public string DisplayPrompts()
    {   
        string prompt = "";
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What is the most interesting thing I did today?",
            "Who is the most helpful person I came across today?",
            "What blessings did I receive today?",
            "What was the best part of my day?",
            "What could I have been done better today?",
            "Did I see something different toda?",
            "What will I do tomorrow that I did not do today?"
        };
        Random rand = new Random();
        List<int> listNumbers = new List<int>();
        do
        {   
            int numbers = rand.Next(0, prompts.Count);
            if(!listNumbers.Contains(numbers)) {
                Console.WriteLine($"{numbers + 1}. {prompts[numbers]}");
                listNumbers.Add(numbers);
                prompt = prompts[numbers];
                break;
            }
        } while (listNumbers.Count < prompts.Count);
        return prompt;
    } 
}