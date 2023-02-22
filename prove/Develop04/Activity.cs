using System;
using System.Globalization;

public class Activity
{
    private string _name;
    private int _duration;
    private string _description;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public int EnterDuration()
    {
        Console.Write("How long, in seconds, would you like for your session?: ");
        int duration = int.Parse(Console.ReadLine());
        return duration;
    }

    public string DisplayWelcome()
    {
        return $"Welcome to the {char.ToUpper(_name[0])}{_name.Substring(1)} Activity";
    }

    public string DisplayDescription()
    {
        return $"This activity will help you {_description}";
    }

    public void DisplayFinish()
    {
        Console.WriteLine("Well done!!");
        LoadingAnimation(4);
        Console.Write($"\nYou have completed another {_duration} seconds of the {char.ToUpper(_name[0])}{_name.Substring(1)} Activity\n");
        LoadingAnimation(4);
    }

    public void LoadingAnimation(int number)
    {
        DateTime start = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(number);

        while(DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");    
        }
    }

    public void BeginDelay()
    {
        int seconds = 5;

        Console.Write("\nYou may begin in: ");
        while(seconds > 0)
        {
            Console.Write($"{seconds}");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
        Console.WriteLine("");
    }
}