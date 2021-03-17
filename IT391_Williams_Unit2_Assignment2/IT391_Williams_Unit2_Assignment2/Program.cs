using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit2_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> customers = new Queue<string>();
            customers.Enqueue("Jim");
            customers.Enqueue("Bob");
            customers.Enqueue("Susan");
            customers.Enqueue("Liz");
            customers.Enqueue("Alex");

            Console.WriteLine("There are {0} customers in line when the bank opens.",customers.Count);

            foreach (string person in customers)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();

            Console.WriteLine("The first customer in line is {0}.", customers.Peek());
            Console.WriteLine("{0} leaves.", customers.Dequeue());
            Console.WriteLine();

            int remaining = customers.Count;

            Queue<String> temp = new Queue<string>();
            temp.Enqueue("Andy");
            temp.Enqueue("Rhonda");

            foreach (string person in temp)
            {
                Console.WriteLine("{0} joins.", person);
                customers.Enqueue(person);
            }
            Console.WriteLine();

            for (int i = 1; i < remaining; i++)
            {
                Console.WriteLine("{0} leaves.",customers.Dequeue());
            }
            Console.WriteLine();

            Console.WriteLine("There are now {0} customers in line.", customers.Count);
            Console.WriteLine("Now the first customer in line is {0}.", customers.Peek());
        }
    }
}
