using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit4_Assignment2_C
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] studentGrades = new int[] { 65, 95, 75, 55, 56, 90, 98, 88, 78 };

            Console.WriteLine("Grades Unsorted");
            printArray(studentGrades);

            sortArrayAsc(studentGrades);
            Console.WriteLine("Bubble Sort Ascending");
            printArray(studentGrades);

            sortArrayDes(studentGrades);
            Console.WriteLine("Bubble Sort Descending");
            printArray(studentGrades);
        }

        private static void sortArrayDes(int[] newArray)
        {
            int length = newArray.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j < (length - i); j++)
                {
                    if (newArray[j - 1] < newArray[j])
                    {
                        int temp = newArray[j - 1];
                        newArray[j - 1] = newArray[j];
                        newArray[j] = temp;
                    }
                }
            }
        }

        private static void sortArrayAsc(int[] newArray)
        {
            int length = newArray.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j < (length - i); j++)
                {
                    if (newArray[j - 1] > newArray[j])
                    {
                        int temp = newArray[j - 1];
                        newArray[j - 1] = newArray[j];
                        newArray[j] = temp;
                    }
                }
            }
        }

        private static void printArray(int[] newArray)
        {
            Console.Write("[");
            for (int low = 0; low <= newArray.GetUpperBound(0); low++)
            {
                Console.Write(newArray[low]);

                if (low != newArray.GetUpperBound(0))
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }
}
