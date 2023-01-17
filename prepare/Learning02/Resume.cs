using System;

public class Resume
{
    //declare the class attributes
    public string _name;
    public List<Job> _jobs = new List<Job>();
    //Create a class method to display 
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        //Crate a foreach loop to call the Display method for each job
        //
        foreach (Job job in _jobs)
        {
            //Calls the Display method for each job in the list
            job.Display();
        }
    }
}