using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit1_Assignment2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] mammals = { "Bear", "Gorilla", "Tiger", "Polar Bear", "Lion", "Monkey" };

            //sets messages for displaying the sets on the console
            String set = "The original set is:  ";
            String sorted = "The sorted set is:  ";


            HashSet<String> setMammals = createSet(mammals);
            displaySet(setMammals, mammals, set);

            SortedSet<String> sortedMammals = sortedSet(setMammals);
            displaySortedSet(sortedMammals, sorted, 1);//displays the full sorted set
            displaySortedSet(sortedMammals, sorted, 2);//displays the first and last elements of the sorted set
        }

        //creates the set
        static HashSet<String> createSet (String [] newArray)
        {
            HashSet<String> newSet = new HashSet<string>();

            try
            {
                for (int i = 0; i <= newArray.GetUpperBound(0); i++)
                {
                    newSet.Add(newArray[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }

            return newSet;
        }


        //creates the sorted set
        static SortedSet<String> sortedSet(HashSet<String> newHashSet)
        {
            SortedSet<String> newSet = new SortedSet<string>(newHashSet);

            return newSet;
        }


        //displays the set to the console
        static void displaySet (HashSet<String> newSet, String [] newArray, String message)
        {
            try
            {
                Console.WriteLine(message);
                Console.Write("[");

                for (int i = 0; i <= newArray.GetUpperBound(0); i++)
                {
                    Console.Write(newArray[i]);

                    if (i == newArray.GetUpperBound(0))
                        Console.WriteLine ("]");
                    else
                        Console.Write(", ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
        }


        //displays the sorted set to the console
        static void displaySortedSet(SortedSet<String> newSortedSet, String message, int option)
        {
            if (option == 1)//the full sorted set
            {
                try
                {
                    Console.WriteLine(message);

                    Console.Write("[");

                    int j = 0;

                    foreach (string mammal in newSortedSet)
                    {
                        Console.Write(mammal);
                        if (j != newSortedSet.Count() - 1)
                            Console.Write(", ");
                        j++;
                    }
                    Console.WriteLine("]");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message.ToString());
                }
            }

            if (option == 2)//the first and last elements
            {
                try
                {
                    Console.WriteLine("The first and last elements of the sorted set are:  ");

                    Console.Write("[");

                    int j = 0;
                    
                    foreach (string mammal in newSortedSet)
                    {
                        if (j == 0)
                            Console.Write(mammal + ", ");
                        if (j == newSortedSet.Count() - 1)
                            Console.Write(mammal);
                        j++;
                    }
                    Console.WriteLine("]");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message.ToString());
                }
            }
        }
    }
}
