using System;

class Program
{
    static void Main(string[] args)
    {
        //Testing the Job class
        //Job job1 = new Job();
        //job1._jobTitle = "Software engineer";
        //job1.Display();

        //Declare an istance for the Job class
        //name job1
        Job job1 = new Job();
        job1._company = "Meta";
        job1._jobTitle = "Data Scientist";
        job1._startYear = 2020;
        job1._endYear = 2022;

        //Declare an istance for the Job class
        //name job2
        Job job2 = new Job();
        job2._company = "Xiaomi";
        job2._jobTitle = "Design Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Declare an istance for the Resume class
        //name resume1
        Resume resume1 = new Resume();
        resume1._name = "Joseph Nicoll";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();

        Console.WriteLine("");

        //Declare an istance for the Job class
        //name job3
        Job job3 = new Job();
        job3._company = "Postobon";
        job3._jobTitle = "Human Resources Assistant";
        job3._startYear = 2018;
        job3._endYear = 2019;

        //Declare an istance for the Job class
        //name job4
        Job job4 = new Job();
        job4._company = "Graphite Connect";
        job4._jobTitle = "Data Quality";
        job4._startYear = 2022;
        job4._endYear = 2023;

        //Declare an istance for the Resume class
        //name resume2
        Resume resume2 = new Resume();
        resume2._name = "Nelson Petro";
        resume2._jobs.Add(job3);
        resume2._jobs.Add(job4);
        resume2.Display();
    }
}