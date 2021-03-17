using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT391_Williams_Unit1_Assignment4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            Console.WriteLine("Building the tree with root value 50");
            Console.WriteLine("*********************************");

            //inserting the data into the tree
            tree.insert(tree.root, tree.addNode(50));
            tree.insert(tree.root, tree.addNode(26));
            tree.insert(tree.root, tree.addNode(15));
            tree.insert(tree.root, tree.addNode(32));
            tree.insert(tree.root, tree.addNode(78));

            Console.WriteLine("Traversing the tree in order");
            Console.WriteLine("*********************************");
            tree.printInOrder(tree.root);

            Console.WriteLine("Traversing the tree in pre-order");
            Console.WriteLine("*********************************");
            tree.printInPreorder(tree.root);

            Console.WriteLine("Traversing the tree in post-order");
            Console.WriteLine("*********************************");
            tree.printInPostorder(tree.root);
        }

        //class for Nodes
        class Node
        {
            public int data;
            public Node left, right;

            public Node (int value)
            {
                this.data = value;
                left = null;
                right = null;
            }

            public Node ()
            {
                left = null;
                right = null;
            }
        }


        //class for Tree
        class BinarySearchTree
        {
            public Node root;

            public BinarySearchTree()
            {
                root = null;
            }

            public Node addNode(int val)
            {
                Node temp = new Node(val);

                if (root == null)
                    root = temp;

                return temp;
            }


            //Insert new Node at proper position
            public void insert (Node rtNode, Node newNode)
            {
                while (rtNode != null)
                {
                    if (newNode.data > rtNode.data)
                    {
                        if (rtNode.right == null)
                        {
                            rtNode.right = newNode;
                            Console.WriteLine("Inserted {0} to the right of node {1}", rtNode.right.data, rtNode.data);
                            break;
                        }
                        rtNode = rtNode.right;
                    }
                    else
                    {
                        if (rtNode.left == null)
                        {
                            rtNode.left = newNode;
                            Console.WriteLine("Inserted {0} to the left of node {1}", rtNode.left.data, rtNode.data);
                            break;
                        }
                        rtNode = rtNode.left;
                    }
                }
            }


            //Print tree in Order
            public void printInOrder (Node nd)
            {
                if (nd != null)
                {
                    printInOrder(nd.left);
                    Console.WriteLine("Traversed {0}", nd.data);
                    printInOrder(nd.right);
                }
            }


            //Print tree in Pre-order
            public void printInPreorder (Node nd)
            {
                if (nd != null)
                {
                    Console.WriteLine("Traversed {0}", nd.data);
                    printInPreorder(nd.left);
                    printInPreorder(nd.right);
                }
            }


            //Print tree in Post-order
            public void printInPostorder (Node nd)
            {
                if (nd != null)
                {
                    printInPostorder(nd.left);
                    printInPostorder(nd.right);
                    Console.WriteLine("Traversed {0}", nd.data);
                }
            }
        }
    }
}
