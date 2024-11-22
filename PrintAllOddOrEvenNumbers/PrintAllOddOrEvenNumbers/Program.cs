using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintAllOddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Numbers");
            Console.WriteLine("Enter an odd number to print all odd numbers");
            Console.WriteLine("Enter an even number to print all even numbers");
            Console.WriteLine("");
            Console.WriteLine("Enter Start Number: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter End Number: ");
            int endNum = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (endNum <= startNum)
            {
                Console.WriteLine("Enter a number > than Start number");
                Console.WriteLine("Enter End Number: ");
                endNum = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (startNum % 2 == 1)
                {
                    Console.WriteLine("Print all odd numbers");
                    for (int i = startNum; i <= endNum; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("Print all even numbers");
                    for (int i = startNum; i <= endNum; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                if (startNum % 2 == 1)
                {
                    Console.WriteLine("Print all odd numbers");
                    for (int i = startNum; i <= endNum; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("Print all even numbers");
                    for (int i = startNum; i <= endNum; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
               
            Console.ReadKey();
        }
    }
}
