 using System;


public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
 
        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
 
            Console.Write("Enter selection: ");
            string userInput = Console.ReadLine();
 
            if (userInput == "1")
            {
                journal.AddEntry();
            }
            else if (userInput == "2")
            {
                journal.DisplayAll();
            }
            else if (userInput == "3")
            {
                Console.Write("Enter the filename to save to: ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
            }
            else if (userInput == "4")
            {
                Console.Write("Enter the filename to load from: ");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Goodbye!");
                break; // Exit the loop
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }
    }
}