using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2001;
        job1._endYear = 2021;
        // Console.WriteLine($"{job1._companyName}");
        // job1.DisplayJob();


        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        // Console.WriteLine($"{job2._companyName}");
        // job2.DisplayJob();

        Resume resume1 = new Resume();
        resume1._name = "Allison";
        resume1._jobsList.Add(job1);
        resume1._jobsList.Add(job2);

        // Console.WriteLine($"Resume: {resume1._jobsList[0]._companyName}");

        resume1.DisplayResume();
    }
}