// responsibility of Job: Keep track of the company, job title, start year and end year and dispaly the information ina set format
using System;

public class Job
{
    // variables
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJob()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }

    
}