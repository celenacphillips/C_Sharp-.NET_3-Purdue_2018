using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit3_Assignment1_C
{
    //  /*
    class Unit3Exercise1
    {
        static void Main(string[] args)
        {
            u3e1();
        }

        static void u3e1()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("{0}!  =  {1}", i, factorial(i));
            }
        }

        public static long factorial (long number)
        {
            if (number <= 1)
                return 1;
            else
                return number * factorial(number - 1);
        }
    }
    //  */



      /*
    class Unit3Exercise2
    {
        static void Main(string[] args)
        {
            u3e2();
        }

        static void u3e2()
        {
            Console.WriteLine("Enter a number up to which the Fibonacci series will print: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonnacci series up to {0} numbers: ", number);

            for (int i = 1; i <= number; i++)
            {
                Console.Write("{0} ", fibonacci(i));
            }
            Console.WriteLine();
        }

        public static int fibonacci (int num)
        {
            if (num == 1 || num == 2)
                return 1;
            else
                return fibonacci(num - 1) + fibonacci(num - 2);
        }
    }
      */



    //  Unit 3, Exercise 3

    //  Recursive Implementation                Iterative Implementation
    //           B                                         A
}
