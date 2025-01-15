using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2011;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._company = "Adobe";
        job2._jobTitle = "Frontend Developer";
        job2._startYear = 2016;
        job2._endYear = 2021;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails(); 

        
    }
}