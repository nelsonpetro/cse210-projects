using System;

class Program
{
    static void Main(string[] args)
    {   
        CSVReader csvtext = new CSVReader();
        List<string> scriptureContent = csvtext.GetLines();
        Reference reference = new Reference(scriptureContent[0], scriptureContent[1], scriptureContent[2], scriptureContent[3]);
        Scripture scripture = new Scripture(scriptureContent[4], reference);
        scripture.WordList();
        scripture.PopulateIndexes();
        Console.Clear();
        while (true)
        {
            scripture.DisplayList();
            Console.Write("\n\nPress enter to hide a word or type quit to exit:");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();
                scripture.HideWords();
                if (!scripture.AllWordsHidden())
                {
                    scripture.DisplayList();
                    Console.WriteLine("\n\nAll words have been hidden!");
                    break;
                }
            }
        }
    }
}