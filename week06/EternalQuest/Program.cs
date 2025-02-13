using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You have   points.");

        

        while(true)
        {
            Console.WriteLine("Menu Options: ");

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {

            }

            else if (userInput == "2")
            {

            }

            else if (userInput == "3")
            {

            }

            else if (userInput == "4")
            {

            

            }

            else if (userInput == "5")
            {

            }

            else if (userInput == "6")
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Please select a choice from the menu ");
            }
        }
    }
}