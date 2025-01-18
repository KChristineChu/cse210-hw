using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while(true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");

            Console.Write("Enter selection: ");
            string userInput = Console.ReadLine();

            //Console.WriteLine($"User selected {userInput}");

            if (userInput == "1")
            {
                //Console.WriteLine("Write a new entry");
                journal.AddEntry();
            } 
            else if (userInput == "2")
            {
                //Console.WriteLine("Display journal");
                journal.DisplayAll();
            } 
            else if (userInput == "3")
            {
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            } 
            else if (userInput == "4")
            {
                Console.WriteLine("Enter the filename ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);

            } 
            else if (userInput == "5")
            {
                return;
            } 
            else
            {
                Console.WriteLine("Please try again.");
            }
        }
    }
}