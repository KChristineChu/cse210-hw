using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult (userName, squareNumber);
    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }    

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    } 

    static int SquareNumber(int number)
    {
        int squareNum = number * number;
        return squareNum;
    } 

    static void DisplayResult (string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your favorite number is: {squareNumber}."); 
    }
    
}