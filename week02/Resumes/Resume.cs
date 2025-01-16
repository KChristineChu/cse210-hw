using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class Resume
{   
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}