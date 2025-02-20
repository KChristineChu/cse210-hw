using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine();

        Running running1 = new Running (new DateTime (2024, 10, 5), 20, 3);
        Running running2 = new Running (new DateTime (2014, 11, 14), 35, 4);
        
        Cycling cycling1 = new Cycling (new DateTime (2024, 12, 20), 40, 10);
        Cycling cycling2 = new Cycling (new DateTime (2025, 1, 18), 50, 12);

        Swimming swimming1 = new Swimming (new DateTime (2025, 2, 14), 30, 20);

        List<Activity> activities = new List<Activity> {running1, running2, cycling1, cycling2, swimming1};
        foreach (Activity activity in activities)
        {
           Console.WriteLine(activity.GetSummary()); 

        }
        Console.WriteLine();
    }
}