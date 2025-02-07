using System;
using homework;
namespace homework
{

    class Program
    {
        static void Main(string[] args)
        {
        Assignment assignment = new ("Jones", "History");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new ("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new ("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetWritingInformation());
        }


    }
}    