using System;
//Create a class named Job
public class Job
{
    //Declare the class attributes
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    //Declare a class method to display the attributes
    //as desired "Job Title (Company) StartYear-EndYear"
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

