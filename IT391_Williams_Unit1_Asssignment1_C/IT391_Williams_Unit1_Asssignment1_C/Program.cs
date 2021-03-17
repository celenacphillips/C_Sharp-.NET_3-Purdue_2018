using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit1_Asssignment1_C
{
    //  /*
    //class 1 of 3
    class Unit1Exercise1
    {
        static void Main(string[] args)
        {
            u1e1();
        }

        private static void u1e1 ()
        {
            String[] professions = new String[] {"Software Engineer", "Programmer", "Database Admin", "Network Admin", "Web Developer", "Program Manager"};

            HashSet<String> setProfessions = new HashSet<string>();

            try
            {
                for (int i = 0; i <= professions.GetUpperBound(0); i++)
                {
                    setProfessions.Add(professions[i]);
                }

                Console.Write("[");

                for (int i = 0; i <= professions.GetUpperBound(0); i++)
                {
                    Console.Write(professions[i]);

                    if (i == professions.GetUpperBound(0))
                        Console.Write("]");
                    else
                        Console.Write(", ");
                }

                Console.WriteLine("\nThe sorted list is: ");
                SortedSet<String> sortedProfessions = new SortedSet<string>(setProfessions);

                Console.Write("[");

                int j = 0;

                foreach (string job in sortedProfessions)
                {
                    Console.Write(job);
                    if (j != sortedProfessions.Count() - 1)
                        Console.Write(", ");
                    j++;
                }
                Console.Write("]");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }

            Console.ReadLine();
        }
    }
    //  */



      /*
    //class 2 of 3
    class Unit1Exercise2
    {
        static void Main (string[] args)
        {
            u1e2();
        }

        private static void u1e2()
        {
            List<String> lstbooks = new List<String>();
            lstbooks.Add("To Kill a Mockingbird");
            lstbooks.Add("Huckleberry Finn");
            lstbooks.Add("Pride and Prejudice");
            lstbooks.Add("Brave New World");
            lstbooks.Add("Lord of the Flies");
            lstbooks.Add("Alice in Wonderland");
            lstbooks.Add("The Old Man and the Sea");
            lstbooks.Add("Atlas Shrugged");

            Console.WriteLine("The original contents of myBooks: ");
            DisplayList(lstbooks);

            lstbooks.Sort();

            Console.WriteLine("myBooks sorted alphabetically: ");
            DisplayList(lstbooks);

            lstbooks.RemoveAt(1);
            lstbooks.RemoveAt(0);
            lstbooks.RemoveAt(lstbooks.Count() - 1);

            Console.WriteLine("Contents of myBooks after deletions: ");
            DisplayList(lstbooks);

            Console.WriteLine("My new books list: ");
            Console.WriteLine(lstbooks.Count());

            int index = lstbooks.IndexOf("Brave New World");
            Console.WriteLine(index == -1 ? false : true);
        }

        private static void DisplayList (List<String> lst)
        {
            Console.Write("[");

            for (int i = 0; i < lst.Count(); i++)
            {
                Console.Write(lst[i]);

                if (i != lst.Count() - 1)
                    Console.Write(", ");
            }

            Console.WriteLine("]");
        }
    }
      */



      /*
    //class 3 of 3
    class Unit1Exercise3
    {
        static void Main (string[] args)
        {
            u1e3();
        }

        private static void u1e3()
        {
            new BinaryTree().create();
            Console.ReadLine();
        }

        public class Node
        {
            public Node left, right;
            public int value;

            public Node(int newValue)
            {
                this.value = newValue;
            }
        }

        public class BinaryTree
        {
            public void create ()
            {
                Node rootnode = new Node(50);
                Console.WriteLine("Building the tree with root value {0}", rootnode.value);

                Console.WriteLine("**************************");
                insert(rootnode, 30);
                insert(rootnode, 45);
                insert(rootnode, 12);
                insert(rootnode, 29);
                Console.WriteLine();

                traverse(rootnode);
            }

            public void traverse(Node rtnode)
            {
                Console.WriteLine("Traversing the tree in order");
                Console.WriteLine("**************************");
                printInOrder(rtnode);
            }

            public void insert (Node nd, int val)
            {
                if (val < nd.value)
                {
                    if (nd.left != null)
                        insert(nd.left, val);
                    else
                    {
                        Console.WriteLine("Inserted {0} to left of node {1}", val, nd.value);
                        nd.left = new Node(val);
                    }
                }
                else if (val > nd.value)
                {
                    if (nd.right != null)
                        insert(nd.right, val);
                    else
                    {
                        Console.WriteLine("Inserted {0} to the right of node {1}", val, nd.value);
                        nd.right = new Node(val);
                    }
                }
            }

            public void printInOrder (Node nd)
            {
                if (nd != null)
                {
                    printInOrder(nd.left);
                    Console.WriteLine("Traversed {0}", nd.value);
                    printInOrder(nd.right);
                }
            }
        }
    }
      */
}
