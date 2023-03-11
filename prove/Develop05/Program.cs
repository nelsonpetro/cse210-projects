using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        Menu menu = new Menu();
        ManageGoals manage = new ManageGoals();
        int choice = 1;
        Console.Clear();

        do
        {
            Console.WriteLine($"Total points: \u25BA {manage.DisplayTotalPoints()} \u25C4\n");
            menu.DisplayMenu();
            Console.Write("\n");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch(choice)
            {
                case 1:
                    menu.DisplayType();
                    Console.Write("Which type of goal would you like to create?: ");
                    int type = int.Parse(Console.ReadLine());
                    if(type == 1)
                    {
                        Console.Write("\n");
                        Simple simpleGoal = new Simple("", "", 0, false);
                        simpleGoal.CreateGoal();
                        goals.Add(simpleGoal);
                        Console.Clear();
                    }
                    else if(type == 2)
                    {
                        Console.Write("\n");
                        Eternal eternalGoal = new Eternal("", "", 0);
                        eternalGoal.CreateGoal();
                        goals.Add(eternalGoal);
                        Console.Clear();
                    }
                    else if(type == 3)
                    {
                        Console.Write("\n");
                        Checklist chklGoal = new Checklist("", "", 0, 0, 0, 0);
                        chklGoal.CreateGoal();
                        goals.Add(chklGoal);
                        Console.Clear();
                    }
                    break;
                case 2:
                    manage.ListGoals(goals);
                    Console.Write("\n");
                    break;
                case 3:
                    manage.Save(goals);
                    Console.Clear();
                    break;
                case 4:
                    manage.CreateGoal(goals);
                    Console.Clear();
                    break;
                case 5:
                    manage.Events(goals);
                    break;
            }
        }while(choice != 6); 
    }
}