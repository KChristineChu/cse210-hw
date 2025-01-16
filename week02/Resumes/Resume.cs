using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class Resume
{   
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        