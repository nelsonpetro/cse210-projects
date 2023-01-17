using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();
        int choice = int.Parse(Console.ReadLine());
        switch (choice){
            case 1:
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Prompts randomPromt = new Prompts();
                string displayedPrompt = randomPromt.DisplayPrompts();
                Entry entry = new Entry();
                entry._text = Console.ReadLine();
                entry._date = dateText;
                entry._prompt = displayedPrompt;
                entry.GenerateEntry();
                break;   
        }             
    }
}