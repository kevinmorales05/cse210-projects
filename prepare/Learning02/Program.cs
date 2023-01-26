using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._company =  "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._endYear = 2022;
        job1._startYear =2021;
        Job job2 = new Job();
        job2._company =  "Apple";
        job2._jobTitle = "Mobile Engineer";
        job2._endYear = 2021;
        job2._startYear =2019;
        //Console.WriteLine(job1._company);
        //Console.WriteLine(job2._company);
        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();
        Resume kevinResume = new Resume();
        kevinResume._name ="Kevin Morales";
        kevinResume.Add_jobs(job1);
        kevinResume.Add_jobs(job2);
        kevinResume.DisplayResumeDetails();




    }
}