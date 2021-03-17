using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit4_Assignment3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentGrades = new int[] { 65, 95, 75, 55, 56, 90, 98, 88, 78 };

            Console.WriteLine("Grades Unsorted");
            printArray(studentGrades);

            sortArrayAsc(studentGrades, 0, studentGrades.Length - 1);
            Console.WriteLine("Quick Sort Ascending");
            printArray(studentGrades);

            sortArrayDes(studentGrades, 0, studentGrades.Length - 1);
            Console.WriteLine("Quick Sort Descending");
            printArray(studentGrades);

        }

        private static void sortArrayDes(int[] newArray, int lower, int upper)
        {
            if (newArray == null || newArray.Length == 0)
                return;

            int middle = lower + (upper - lower) / 2;
            int pivot = newArray[middle];

            int low = lower, high = upper;

            while (low <= high)
            {
                while (newArray[low] > pivot)
                {
                    low++;
                }

                while (newArray[high] < pivot)
                {
                    high--;
                }

                if (low <= high)
                {
                    int temp = newArray[high];
                    newArray[high] = newArray[low];
                    newArray[low] = temp;

                    low++;
                    high--;
                }
            }

            if (lower < high)
                sortArrayDes(newArray, lower, high);

            if (upper > low)
                sortArrayDes(newArray, low, upper);
        }

        private static void sortArrayAsc(int[] newArray, int lower, int upper)
        {
            if (newArray == null || newArray.Length == 0)
                return;

            int middle = lower + (upper - lower) / 2;
            int pivot = newArray[middle];

            int low = lower, high = upper;

            while (low <= high)
            {
                while (newArray[low] < pivot)
                {
                    low++;
                }

                while (newArray[high] > pivot)
                {
                    high--;
                }

                if (low <= high)
                {
                    int temp = newArray[low];
                    newArray[low] = newArray[high];
                    newArray[high] = temp;

                    low++;
                    high--;
                }
            }

            if (lower < high)
                sortArrayAsc(newArray, lower, high);

            if (upper > low)
                sortArrayAsc(newArray, low, upper);
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
