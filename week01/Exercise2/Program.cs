using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        if (percentage >= 90)
        {
            Console.WriteLine("A");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("D");
        }
        else 
        {
            Console.WriteLine("F");
        }
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! you passed.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Please try hard.");
        }
    }
    
}