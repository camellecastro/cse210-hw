using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sales Development";
        job1._company = "Workstream";
        job1._startYear = 2023;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Co-Founder";
        job2._company = "HireWay";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Job job3 = new Job();
        job3._jobTitle = "Investor";
        job3._company = "Campus Founders Fund";
        job3._startYear = 2022;
        job3._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Dylan Kirkland";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}