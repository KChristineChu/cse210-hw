using System;
using assignment_exercise;

class Program
{
    static void Main(string[] args)
    {
       Assignment assignment = new ("Jones", "History");
       Console.WriteLine(assignment.GetSummary());
    }
}