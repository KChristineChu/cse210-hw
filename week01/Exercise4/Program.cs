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
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            
            number = int.Parse(Console.ReadLine()); 

            if (number != 0)
            {
                numList.Add(number);
            }    
       }
        
        
        
        
        
    }
}
