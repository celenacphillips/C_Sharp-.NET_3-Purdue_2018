using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit1_Assignment3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> myFriends = createList();
            Console.WriteLine("The original list:");
            displayList(myFriends);//displays original list

            //modifications to friends list
            myFriends.Remove("Bill 520-456-9823");
            myFriends.RemoveAt(0);//remove the first friend
            myFriends.RemoveAt(myFriends.Count - 1);//remove the last friend

            //insert Mary's new number and remove the old number
            myFriends.Insert(myFriends.IndexOf("Mary 520-788-3457"), "Mary 520-897-4567");
            myFriends.Remove("Mary 520-788-3457");


            Console.WriteLine("The modified list:");
            displayList(myFriends);//displays modified list
            Console.WriteLine("I have {0} friends in my list.", myFriends.Count);
            Console.WriteLine("Fred is in my friends list. {0}", myFriends.Contains("Fred 602-299-3300"));
        }


        //creates the linked list
        static List<String> createList ()
        {
            List<String> newList = new List<string>();
            newList.Add("Bill 520-456-9823");
            newList.Add("Susan 520-891-8745");
            newList.Add("Dorothy 520-689-9745");
            newList.Add("Fred 602-299-3300");
            newList.Add("Grace 250-544-9898");
            newList.Add("Mary 520-788-3457");
            newList.Add("Sam 602-343-8723");
            newList.Add("Ann 602-555-4949");

            return newList;
        }


        //displays the list to the console
        static void displayList (List<String> newList)
        {
            for (int i = 0; i < newList.Count(); i++)
            {
                Console.WriteLine (newList[i]);
            }
            Console.WriteLine();
        }
    }
}
