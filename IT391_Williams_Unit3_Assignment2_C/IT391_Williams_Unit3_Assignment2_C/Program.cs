using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit3_Assignment2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number up to which the program will iterate factorials:");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("\nFactorial series from 1 to {0}", input);
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine("{0}!  =  {1}", i, factorial(i));
            }
        }

        public static int factorial(int number)
        {
            if (number <= 1)
                return 1;
            else
                return number * factorial(number - 1);
        }

    }
}
