using System;
using System.Text;

public class CSVReader
{
    public List<string> GetLines()
    {
        string filename = "scriptures.csv";

        var lines = System.IO.File.ReadAllLines(filename).Skip(1).ToList();

        Random rand = new Random();
        
        int number = rand.Next(0, lines.Count);

        string scripture = lines[number]; 

        List<string> result = new List<string>();

        StringBuilder currentStr = new StringBuilder("");
        
        bool inQuotes = false;

        for (int i = 0; i < scripture.Length; i++)
        {
            if (scripture[i] == '\"')

                inQuotes = !inQuotes;

            else if (scripture[i] == ',')
            {
                if (!inQuotes)
                {
                    result.Add(currentStr.ToString());

                    currentStr.Clear();
                }
                else
                {
                    currentStr.Append(scripture[i]); 
                }
            }
            else
            {
                currentStr.Append(scripture[i]);
            }  
        }
        result.Add(currentStr.ToString());

        return result;
    }
}