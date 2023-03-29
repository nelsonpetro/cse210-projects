using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(new DateTime(2023, 3, 28), 30, 3);
        Cycling cycling = new Cycling(new DateTime(2022, 3, 29), 20, 15);
        Swimming swimming = new Swimming(new DateTime(2022, 3, 30), 40, 20);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Call GetSummary method on each activity and display the results
        foreach (Activity activity in activities)
        {
            string name;

            if(activity is Running)
            {
                name = "Running";
            }
            else if (activity is Cycling)
            {
                name = "Cycling";
            }
            else
            {
                name = "Swimming";
            }

            Console.WriteLine(activity.Summary(name));
        }
    }
}