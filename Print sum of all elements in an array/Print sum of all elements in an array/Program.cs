using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Print_sum_of_all_elements_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
            int[] number = { 1, 5, 7, 6, 5 };
            while (i < 5) {
                sum = sum + number[i];
                i = i+1;
            } 
            Console.WriteLine("Sum is = "+sum);
            Console.ReadKey();
        }
    }
}
