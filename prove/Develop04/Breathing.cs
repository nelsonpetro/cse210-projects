using System;

public class Breathing : Activity
{

    public Breathing(string name, string description) : base(name, description)
    {
        name = "";
        description = "";
    }

    public void InhaleExhale()
    {
        int duration = GetDuration();

        DateTime start = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        
        void countDown(int seconds)
        {
            while(seconds > 0)
            {
                Console.Write($"{seconds}");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b \b");
                seconds--;
            }
        }

        while(DateTime.Now < endTime)
        {
            Console.Write($"Breathe in...");
            countDown(4);
            Console.Write($"\nBreathe out...");
            countDown(6);
            Console.WriteLine("\n");
        }
    }
}
