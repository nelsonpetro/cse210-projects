using System;
using System.Text;

public class CSVReader
{
    public List<string> GetLines()
    {
        string filename = "scriptures.csv";
        var lines = System.IO.File.ReadAllLines(filename).Skip(1).ToList();
        Random rand = new Random();
        //select a random scripture from the CSV file
        int number = rand.Next(0, lines.Count);
        string scripture = lines[number]; 
        List<string> result = new List<string>();
        StringBuilder currentStr = new StringBuilder("");
        bool inQuotes = false;
        for (int i = 0; i < scripture.Length; i++) // For each character
        {
            if (scripture[i] == '\"') // Quotes are closing or opening
                inQuotes = !inQuotes;
            else if (scripture[i] == ',') // Comma
            {
                if (!inQuotes) // If not in quotes, end of current string, add it to result
                {
                    result.Add(currentStr.ToString());
                    currentStr.Clear();
                }
                else
                {
                    currentStr.Append(scripture[i]); // If in quotes, just add it 
                }
            }
            else
            {
                // Add any other character to current string
                currentStr.Append(scripture[i]);
            }  
        }
        result.Add(currentStr.ToString());
        return result;
    }
}