using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit4_Assignment5_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] partNumbers = new int[] { 1065, 1095, 1075, 1055, 1056, 1090, 1098, 1088, 1097, 1078 };
            Array.Sort(partNumbers);

            Console.WriteLine("Enter two part numbers, pressing [ENTER] after each.");
            int part1 = int.Parse(Console.ReadLine());
            int part2 = int.Parse(Console.ReadLine());

            binarySearch(partNumbers, 0, partNumbers.Length, part1);
            binarySearch(partNumbers, 0, partNumbers.Length, part2);
        }

        private static void binarySearch (int [] x, int lower, int upper, int key)
        {
            int position = (lower + upper) / 2;

            while (lower <= upper)
            {
                if (x[position] < key)
                    lower = position + 1;
                else if (x[position] == key)
                {
                    Console.WriteLine("The part number was found at index {0}.", position);
                    Console.WriteLine("{0} is in stock", key);
                    break;
                }
                else
                    upper = position - 1;

                position = (lower + upper) / 2;
            }

            if (lower > upper)
            {
                Console.WriteLine("{0} is not in stock", key);
            }
        }
    }
}
