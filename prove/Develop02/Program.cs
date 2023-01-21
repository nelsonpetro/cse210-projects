using System;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        ManageDB connection = new ManageDB();
        connection.CreateConnection();
        connection.CreateTempConnection();
        Prompts randomPromt = new Prompts();
        int choice = 1;
        do
        {
            Menu menu = new Menu();
            Console.WriteLine("");
            menu.DisplayMenu();
            Entry entry = new Entry();
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    Console.WriteLine("");
                    string displayedPrompt = randomPromt.DisplayPrompts();
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    Console.Write(">");
                    entry._text = Console.ReadLine();
                    entry._date = dateText;
                    entry._prompt = displayedPrompt;
                    List<string> valuesList = entry.GenerateEntry();
                    connection.Write(valuesList);
                    break;
                case 2:
                    Console.WriteLine("");
                    connection.GetRecords();
                    break;
                case 3:
                    Console.WriteLine("");
                    connection.GetAllRecords();
                    break;
                case 4:
                    Console.WriteLine("");
                    connection.DiscardEntries();
                    break;
                case 5:
                    Console.WriteLine("");
                    connection.SaveEntries();
                    break;
                case 6:
                    Console.Write("\nPlease, enter the entry number you want to delete: ");
                    int target = int.Parse(Console.ReadLine());
                    connection.DeleteEspEntry(target);
                    break;
                case 7:
                    connection.DeleteAllEntries();
                    break;
                case 8:
                    Console.Write("Keep counting your blessings!");
                    break;
                default:
                    Console.WriteLine("\nYou entered an invalid option. Try again with a number from 1 to 8.");
                    break;
            }
            
        }while(choice!=8);
    }
}