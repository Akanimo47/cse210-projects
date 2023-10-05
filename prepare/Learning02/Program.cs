using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Wesco";
        job1._jobTitle = "Telemarketing Agent";
        job1._startYear = 2012;
        job1._endYear = 2014;

        Job job2 = new Job();
        job2._companyName = "Lincon";
        job2._jobTitle = "Technician";
        job2._startYear = 2016;
        job2._endYear = 2022;

        Resume resume1 = new Resume();
        resume1._name = "Juan";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResumeDetails();
    }
}
