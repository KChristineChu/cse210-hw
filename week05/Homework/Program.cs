using System;
using homework;


class Program
{
    static void Main(string[] args)
    {
       Assignment assignment = new ("Jones", "History");
       Console.WriteLine(assignment.GetSummary());

       MathAssignment mathAssignment = new ("Robert Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
       Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}