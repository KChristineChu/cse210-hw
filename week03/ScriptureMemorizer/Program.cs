using System;

class Program
{
    static void Main(string[] args)
    {
        //Word word = new Word();
        //Console.WriteLine(word.GetDisplayText());

        Reference reference = new Reference("John", 3, 16, 17);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life.\n For God sent not His Son into the world to condemn the world; but that the world through Him might be saved.");

        //loop 
            // display, hide, check if we need to quit
            // use the functions in the Scripture class

        string userInput = "";
        
        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            Console.WriteLine();
            Console.WriteLine("Press enter key to continue or type 'quit' to end");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());


        //Reference reference = new Reference("Proverbs", 3, 5);
        //Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
    }
}