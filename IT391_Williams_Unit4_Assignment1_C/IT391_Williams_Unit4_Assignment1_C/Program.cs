using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit4_Assignment1_C
{
    //  /*
    class Exercise1
    {
        static void Main(string[] args)
        {
            u4e1();
        }

        static void u4e1()
        {
            int[] studentIDs = { 6501, 9503, 7557, 5535, 5601, 9001, 9888, 8801, 9767, 7815 };

            Console.Write("List of Student IDs unsorted [");
            for (int i = 0; i <= studentIDs.GetUpperBound(0); i++)
            {
                Console.Write(studentIDs[i]);

                if (i != studentIDs.GetUpperBound(0))
                    Console.Write(", ");
            }
            Console.WriteLine("]");

            int low = 0, high = studentIDs.Length - 1;

            sortAsc(studentIDs, low, high);

            Console.Write("List of Student IDs sorted [");
            for (int i = 0; i <= studentIDs.GetUpperBound(0); i++)
            {
                Console.Write(studentIDs[i]);

                if (i != studentIDs.GetUpperBound(0))
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        public static void sortAsc(int[] array, int lower, int upper)
        {
            if (array == null || array.Length == 0)
                return;

            if (lower >= upper)
                return;

            int middle = lower + (upper - lower) / 2;
            int pivot = array[middle];

            int i = lower, j = upper;

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (lower < j)
                sortAsc(array, lower, j);

            if (upper > i)
                sortAsc(array, i, upper);
        }
    }
    //  */


      /*
    class Exercise2
    {
        static void Main(string[] args)
        {
            u4e2();
        }

        static void u4e2()
        {
            int[] intArray = new int[] { 5, 90, 35, 45, 150, 3 };

            Console.WriteLine("Array before Bubble Sort");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write("{0} ", intArray[i]);
            }

            bubbleSort(intArray);
            Console.WriteLine();

            Console.WriteLine("Array after Bubble Sort");
            for (int i = 0; i <intArray.Length; i++)
            {
                Console.Write("{0} ", intArray[i]);
            }
            Console.WriteLine();
        }

        private static void bubbleSort (int [] array)
        {
            int len = array.Length;
            
            for (int i = 0; i < len; i++)
            {
                for (int j = 1; j < (len - i); j++)
                {
                    if (array[j-1] > array [j])
                    {
                        int temp = array[j-1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
      */


      /*
    class Exercise3
    {
        static void Main(string[] args)
        {
            u4e3();
        }

        static void u4e3 ()
        {
            Console.WriteLine("Enter a number of elements");
            int elements = int.Parse(Console.ReadLine());

            int[] array = new int[elements];

            Console.WriteLine("Enter {0} integers", elements);

            for (int i = 0; i < elements; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the value you want to find");
            int search = int.Parse(Console.ReadLine());

            int first = 0, last = elements - 1, middle = (first + last) / 2;

            while (first <= last)
            {
                if (array[middle] < search)
                    first = middle + 1;
                else if (array[middle] == search)
                {
                    Console.WriteLine("{0} found at location {1}.", search, (middle + 1));
                    break;
                }
                else
                    last = middle - 1;

                middle = (first + last) / 2;
            }

            if (first > last)
                Console.WriteLine("{0} is not present in the list.", search);
        }
    }
      */
}
