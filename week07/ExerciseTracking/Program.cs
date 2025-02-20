using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine();

        Running running1 = new Running (new DateTime(2024, 10, 5), 20, 3);

        Cycling cycling1 = new Cycling (new DateTime (2024, 12, 20), 40, 10);

        Swimming swimming1 = new Swimming (new DateTime (2025, 2, 14), 30, 20);

        List<Activity> activities = new List<Activity> {running1, cycling1, swimming1};
        foreach (Activity activity in activities)
        {
           Console.WriteLine(activity.GetSummary()); 
        }

        //Console.WriteLine(running1.GetSummary());

        //Console.WriteLine(cycling1.GetSummary());

        //Console.WriteLine(swimming1.GetSummary());
    }
}