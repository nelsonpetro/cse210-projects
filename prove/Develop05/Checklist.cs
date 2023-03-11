using System;

public class Checklist : Goal
{
    private int _totalTimes;
    private int _partialTimes;
    private int _bonus;

    public Checklist(string name, string description, int points, int partialTimes, int totalTimes, int bonus) : base (name, description, points)
    {
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        SetPartialTimes(partialTimes);
        SetTotalTimes(totalTimes);
        SetBonus(bonus);
    }

    public override void CreateGoal()
    {
        Console.Write("Which is the name of your goal?: ");
        string name = Console.ReadLine();
        SetName(name);

        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        SetDescription(description);

        Console.Write("What is the ammount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);

        Console.Write("How many times does this goal need to be completed to get a bonus?: ");
        int totalTimes = int.Parse(Console.ReadLine());
        SetTotalTimes(totalTimes);

        Console.Write("What is the bonus for accomplishing it that many times?: ");
        int bonus = int.Parse(Console.ReadLine());
        SetBonus(bonus);
    }

    public void SetTotalTimes(int totalTimes)
    {
        _totalTimes= totalTimes;
    }

    public override int GetTotalTimes()
    {
        return _totalTimes;
    }

    public void SetPartialTimes(int partialTimes)
    {
        _partialTimes= partialTimes;
    }

    public override int GetPartialTimes()
    {
        return _partialTimes;
    }

    public void SetBonus(int bonus)
    {
        _bonus= bonus;
    }

    public override int GetBonus()
    {
        return _bonus;
    }

    public override void IsComplete()
    {
        _partialTimes ++;

        Console.WriteLine($"\nCongratulations, you have earned {GetPoints()} points.\n");
        if (_partialTimes == _totalTimes)
        {
            Console.WriteLine($"\r\u2191\u2191 Congratulations, you have earned {GetBonus()} bonus points \u2191\u2191\n");
        }
    }
}