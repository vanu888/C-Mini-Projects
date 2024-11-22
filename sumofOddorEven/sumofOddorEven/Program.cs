using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumofEven
{
    class Program
    {
        static void Main(string[] args)
        {
           int sum = 0;
           Console.WriteLine("Calculate sum of even or odd numbers");
           Console.WriteLine("");
           Console.WriteLine("Enter 1 for odd and enter 2 for even");
           int userInput = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter the end number");
           int endNum = int.Parse(Console.ReadLine());
           if (userInput == 1)
           {
               for (int i = 1; i <= endNum; i = i + 2)
               {
                   sum = sum + i;
               }
           }
           else if (userInput == 2)
           {
               for (int i = 0; i <= endNum; i = i + 2)
               {
                   sum = sum + i;
               }
           }
           else
           {
               Console.WriteLine("Invalid Input");
           }
           Console.WriteLine("Sum is = " + sum);
           Console.ReadKey();
        }
    }
}
