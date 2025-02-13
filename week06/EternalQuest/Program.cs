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
            string userInput1 = Console.ReadLine();

            if (userInput1 == "1")
            {
                while(true)
                {
                    Console.WriteLine("The types of Goals are: ");

                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");

                    Console.Write("What type of goal would you like to create? ");
                    string userInput2 = Console.ReadLine();

                    if (userInput2 == "1")
                    {

                    }
                    if (userInput2 == "2")
                    {

                    }
                    if (userInput2 == "3")
                    {

                    }
                }

            }

            else if (userInput1 == "2")
            {

            }

            else if (userInput1 == "3")
            {

            }

            else if (userInput1 == "4")
            {

            

            }

            else if (userInput1 == "5")
            {

            }

            else if (userInput1 == "6")
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