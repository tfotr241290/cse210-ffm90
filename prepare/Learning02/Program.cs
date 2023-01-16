using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Amazon";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2003";
        job1._endYear = "2015";

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Software Engineer";
        job2._startYear = "2016";
        job2._endYear = "2022";


        Resume myResume = new Resume();
        myResume._memberName = "Francisco Franco";
        myResume._memberJobs.Add(job1);
        myResume._memberJobs.Add(job2);

        myResume.DisplayResume();

    }
}