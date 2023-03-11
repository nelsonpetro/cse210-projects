using System;
using System.IO;
using System.Linq;

public class ManageGoals
{
    private int _totalPoints = 0;

    public void ListGoals(List<Goal> goals)
    {

        Console.WriteLine("The Goals are: \n");
        foreach(Goal goal in goals)
        {
            string check = "[ ]";

            if (goal is Simple)
            { 
                if (goal.GetIsComplete())
                {
                    check = "[X]";
                }
                Console.WriteLine($"{goals.IndexOf(goal)+1}. {check} {goal.GetName()} ({goal.GetDescription()})");
            }
            else if (goal is Eternal)
            {
                Console.WriteLine($"{goals.IndexOf(goal)+1}. {check} {goal.GetName()} ({goal.GetDescription()})");
            }
            else if (goal is Checklist)
            {
                if (goal.GetPartialTimes() == goal.GetTotalTimes())
                {
                    check = "[X]";
                }
                Console.WriteLine($"{goals.IndexOf(goal)+1}. {check} {goal.GetName()} ({goal.GetDescription()}) -- Currently Completed {goal.GetPartialTimes()}/{goal.GetTotalTimes()}");
            }
        }
    }

    public void Save(List<Goal> goals)
    {
        Console.Write("What is the filename?: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_totalPoints}");
            foreach(Goal goal in goals)
            {
                if (goal is Simple)
                {
                    outputFile.WriteLine($"simple:{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetIsComplete()}");
                }
                else if (goal is Eternal)
                {
                    outputFile.WriteLine($"eternal:{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}");
                }
                else if (goal is Checklist)
                {

                    outputFile.WriteLine($"checklist:{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetPartialTimes()}|{goal.GetTotalTimes()}|{goal.GetBonus()}");
                }
            }
        }
    }

    public List<Goal> CreateGoal(List<Goal> goals)
    {
        Console.Write("What is the filename?: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        _totalPoints = int.Parse(lines[0]);

        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string type = parts[0];
            string goalContent = parts[1];

            if(type == "simple")
            {
                string[] content = goalContent.Split("|");
                Simple simpleGoal = new Simple(content[0], content[1], int.Parse(content[2]), bool.Parse(content[3]));
                goals.Add(simpleGoal);
            }
            else if(type == "eternal")
            {
                string[] content = goalContent.Split("|");
                Eternal eternalGoal= new Eternal(content[0], content[1], int.Parse(content[2]));
                goals.Add(eternalGoal);
            }
            else if(type == "checklist")
            {
                string[] content = goalContent.Split("|");
                Checklist chklGoal= new Checklist(content[0], content[1], int.Parse(content[2]), int.Parse(content[3]), int.Parse(content[4]), int.Parse(content[5]));
                goals.Add(chklGoal);
            }
        }
        return goals;
    }

    public void Events(List<Goal> goals)
    {
        Console.WriteLine("The Goals are: ");

        foreach(Goal goal in goals)
        {
            Console.WriteLine($"{goals.IndexOf(goal)+1}. {goal.GetName()}");
        }

        Console.Write("Which goal did you accomplish?: ");
        int accomplish = int.Parse(Console.ReadLine())-1;

        goals[accomplish].IsComplete();

        if(goals[accomplish] is Checklist && goals[accomplish].GetPartialTimes() == goals[accomplish].GetTotalTimes())
        {
            _totalPoints += (goals[accomplish].GetPoints() + goals[accomplish].GetBonus());
        }
        else
        {
            _totalPoints += goals[accomplish].GetPoints();
        }
    }

    public int DisplayTotalPoints()
    {
        return _totalPoints;
    }
}