using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit2_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any word then press [ENTER]");
            String word = Console.ReadLine();


            Console.WriteLine("The reversed word is:");
            Console.WriteLine(reverse(word));
        }

        private static String reverse (String newWord)
        {
            String reversedWord = "";
            Stack newStack = new Stack();

            for (int i = 0; i < newWord.Length; i++)
            {
                newStack.Push(newWord.Substring(i, 1));
            }

            while (newStack.Count != 0)
            {
                reversedWord += newStack.Pop();
            }

            return reversedWord;
        }
    }
}
