using System;

public class Menu
{
    private List<string> _menu = new List<string>()
    {
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load Goals",
        "Record Event",
        "Quit"
    };

    private List<string> _goalType = new List<string>()
    {
        "Simple Goal",
        "Eternal Goal",
        "Checklist Goal"
    };

    public void Display(List<string> list)
    {
        foreach(string option in list)
        {
            Console.WriteLine($"   {list.IndexOf(option)+1}. {option}");
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Display(_menu);
    }

    public void DisplayType()
    {
        Console.WriteLine("The types of Goals are: ");
        Display(_goalType);
    }   
}