using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit4_Assignment4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] partNumbers = new int []{ 1065, 1095, 1075, 1055, 1056, 1090, 1098, 1088, 1097, 1078 };

            Console.WriteLine("Enter two part numbers, pressing [ENTER] after each.");
            int key1 = int.Parse(Console.ReadLine());
            int key2 = int.Parse(Console.ReadLine());

            int key1Return = sequentialSearch(partNumbers, key1);
            int key2Return = sequentialSearch(partNumbers, key2);

            if (key1Return != -1)
                Console.WriteLine("{0} is in stock.", key1);
            if (key2Return != -1)
                Console.WriteLine("{0} is in stock.", key2);

            if (key1Return == -1)
                Console.WriteLine("{0} is not in stock.", key1);
            if (key2Return == -1)
                Console.WriteLine("{0} is not in stock.", key2);
        }

        private static int sequentialSearch (int [] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    Console.WriteLine("The part number {0} was found at index {1}.", element, i);
                    return element;
                }
            }

            return -1;
        }
    }
}
