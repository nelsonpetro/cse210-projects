using System;

//I tried to exceed the requirements creating a new class to 
//read the scriptures from a csv file and randomly choosing one on the 
//scriptures to display and hide the words. The class is CSVReader

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter 1 for math assignment and 2 for writting assignment: ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("\nPlease enter the student's name: ");
        string name = Console.ReadLine();
        Console.Write("\nPlease enter the topic: ");
        string topic = Console.ReadLine();

        switch (choice)
        {
            case 1:
                Console.Write("\nPlease enter the textbook section: ");
                string textBookSection = Console.ReadLine();
                Console.Write("\n Please enter the problems: ");
                string problems = Console.ReadLine();
                MathAssignment mathAssignment = new MathAssignment(name, topic, textBookSection, problems);
                Console.WriteLine(mathAssignment.GetSummary());
                Console.Write(mathAssignment.GetHomeworkList());
                break;

            case 2:
                Console.Write("\nPlease enter the title: ");
                string title = Console.ReadLine();
                WritingAssignment writingAssignment = new WritingAssignment(name, topic, title);
                Console.WriteLine(writingAssignment.GetSummary());
                Console.Write(writingAssignment.GetWritingInfo());
                break;             
        }     
    }
}