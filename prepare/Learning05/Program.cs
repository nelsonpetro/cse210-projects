using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        
        void Inhale()
        {
            DateTime start = DateTime.Now;
            DateTime endTime = DateTime.Now.AddSeconds(30);
            
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

        Inhale();
    }
}