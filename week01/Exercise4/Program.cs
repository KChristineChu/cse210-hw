using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       List<int> numList = new List<int>();

       int number = -1;
       while (number != 0) 
       {
            Console.Write("Enter a number, type 0 when finished. ");
            
            number = int.Parse(Console.ReadLine()); 

            if (number != 0)
            {
                numList.Add(number);
            }    
       }
        int sum = 0;
        foreach (int num in numList)
        {
            sum += num;
        }
        
        Console.WriteLine($"The total is: {sum}");
        
        int average = sum/ numList.Count;

        Console.WriteLine($"The average is: {average}");

        int max = 0;
        foreach (int num in numList)
        {
            if (num > max)
            max = num;

        }
        Console.WriteLine($"The maximum number is: {max}");


    }
}
