using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit2_Assignment1
{
    //  Unit 2 Exercise 1

    //   Data Structure     Figure
    //       Stack            B
    //       Queue            A


    //  /*
    class Unit2Exercise2
    {
        static void Main(string[] args)
        {
            u2e2();
        }

        static void u2e2()
        {
            Console.WriteLine("Enter any series of 5 numbers with no punctuation or spaces: ");

            String input = Console.ReadLine();
            Console.WriteLine(reversedNum(input));
        }

        public static String reversedNum (String num)
        {
            Stack st = new Stack();

            for (int i = 0; i < num.Length; i++)
            {
                st.Push(num.Substring(i, 1));
            }

            String reversed = "";

            while (st.Count != 0)
            {
                reversed += st.Pop();
            }

            return reversed;
        }
    }
    // */


      /*
    class Unit2Exercise3
    {
        static void Main(string[] args)
        {
            u2e3();
        }

        static void u2e3()
        {
            Queue<String> shoppers = new Queue<string>();
            shoppers.Enqueue("Jane");
            shoppers.Enqueue("Bob");
            shoppers.Enqueue("Liza");
            shoppers.Enqueue("Tom");
            shoppers.Enqueue("Mary");

            

            Console.WriteLine("The number of shoppers at the grocery store when the store opens is {0}", shoppers.Count);

            foreach (var person in shoppers)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("The first shopper in line is {0}.", shoppers.Peek());
            shoppers.Dequeue();

            int shopperCount = shoppers.Count;

            shoppers.Enqueue("Stephen");
            shoppers.Enqueue("Ellen");

            for (int i =1; i < shopperCount; i++)
            {
                shoppers.Dequeue();
            }

            Console.WriteLine("There are now {0} shoppers in line.", shoppers.Count);
            Console.WriteLine("{0} is now at the head of the line.", shoppers.Peek());
        }
    }
      */
}
