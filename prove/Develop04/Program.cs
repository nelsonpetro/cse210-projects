using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> options = new List<string>()
        {
            "Start breathing activity",
            "Start reflection activity",
            "Start listing activity",
            "Quit"
        };

        List<string> descriptions = new List<string>()
        {
            "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
            "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            "reflect on the good things in your life by having you list as many things as you can in a certain area."
        };

        Reflection reflection = new Reflection(options[1].Split(" ")[1], descriptions[1]);

        reflection.PopulateIndexesPrompts();
        reflection.PopulateIndexesQuestions();

        Listing listing = new Listing(options[2].Split(" ")[1], descriptions[2]);

        listing.PopulateIndexes();

        int choice = 1;

        do
        {
            Console.WriteLine("Menu options:");
            foreach(string option in options)
            {
                Console.WriteLine($"\t\b\b\b\b{options.IndexOf(option)+1}. {option}");
            }
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch(choice)
            {
                case 1:
                    Breathing breathing = new Breathing(options[0].Split(" ")[1], descriptions[0]);
                    Console.WriteLine($"{breathing.DisplayWelcome()}\n");
                    Console.WriteLine($"{breathing.DisplayDescription()}\n");
                    breathing.SetDuration(breathing.EnterDuration());
                    Console.Clear();
                    Console.Write("Get ready...");
                    breathing.LoadingAnimation(4);
                    Console.WriteLine("\n");
                    breathing.InhaleExhale();
                    breathing.DisplayFinish();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine($"{reflection.DisplayWelcome()}\n");
                    Console.WriteLine($"{reflection.DisplayDescription()}\n");
                    reflection.SetDuration(reflection.EnterDuration());
                    Console.Clear();
                    Console.Write("Get ready...");
                    reflection.LoadingAnimation(4);
                    Console.WriteLine("\n");
                    reflection.DisplayPrompt();
                    reflection.Instructions();
                    reflection.BeginDelay();
                    Console.Clear();
                    for(int i = 0; i < 2; i++)
                    {
                        reflection.DisplayQuestions();
                        reflection.LoadingAnimation(reflection.GetDuration()/2);
                        Console.WriteLine("\n");
                    }
                    reflection.DisplayFinish();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine($"{reflection.DisplayWelcome()}\n");
                    Console.WriteLine($"{reflection.DisplayDescription()}\n");
                    listing.SetDuration(reflection.EnterDuration());
                    Console.Clear();
                    Console.Write("Get ready...");
                    reflection.LoadingAnimation(4);
                    Console.WriteLine("\n");
                    listing.DisplayQuestions();
                    listing.BeginDelay();
                    listing.GetEntries();
                    listing.DisplayListedItems();
                    listing.DisplayFinish();
                    Console.Clear();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("You entered an invalid option.");
                    Console.Clear();
                    break;
            }
        }while(choice != 4);      
    }
}