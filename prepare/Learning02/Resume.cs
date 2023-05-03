// Resume: keeps track of person's name and a list of their jobs
using System;

public class Resume
{
    // variables
    public string _name;

    public List<Job> _jobsList = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");

        foreach (Job opportunity in _jobsList)
        {
            opportunity.DisplayJob();
        }
    }
}