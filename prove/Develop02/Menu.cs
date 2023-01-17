using System;

public class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        List<string> options = new List<string>()
        {
            "Write",
            "Display",
            "Load",
            "Save",
            "Quit"
        };
        foreach(string option in options)
        {
            Console.WriteLine($"{options.IndexOf(option) + 1}. {option}");
        }
    }
}