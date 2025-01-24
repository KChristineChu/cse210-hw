using System;

class Program
{
    static void Main(string[] args)
    {
        Word word = new Word();
        Console.WriteLine(word.GetDisplayText());

        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life.");

        //loop 
            // display, hide, check if we need to quit
            // use the functions in the Scripture class

        string userInput = "";
        while (userInput != "quit")
        {
            Console.WriteLine("Press enter key to continue or type 'quit' to end");
            userInput = Console.ReadLine();
        }


        //Reference reference = new Reference("Proverbs", 3, 5);
        //Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
    }
}