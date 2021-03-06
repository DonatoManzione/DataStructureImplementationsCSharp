﻿using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> myList = new LinkedList<string>();
            myList.Add("HELLO");
            myList.Add("Donato");
            myList.Add("Developer");
            myList.Remove("Developer");
            Console.WriteLine(myList);
            myList.Clear();

            DoublyLinkedList<string> myList2 = new DoublyLinkedList<string>();
            myList2.Add("Print");
            myList2.Add("This");
            myList2.Add("Backward");
            myList2.Add("But not this");
            myList2.Remove("But not this");
            Console.WriteLine(myList2);
            myList2.Clear();

            Stack<string> myStack = new Stack<string>();
            myStack.Push("FIRST STACK EL");
            Console.WriteLine(myStack);
            myStack.Push("SECOND STACK EL");
            Console.WriteLine(myStack);
            myStack.Push("THIRD STACK EL");
            Console.WriteLine(myStack);
            myStack.Push("FOURTH STACK EL");
            Console.WriteLine(myStack);
            myStack.Push("FIFTH STACK EL");
            Console.WriteLine(myStack);
            myStack.Push("SIXTH STACK EL");
            Console.WriteLine(myStack);
            while(myStack.Count > 0)
            {
                myStack.Pop();
                Console.WriteLine(myStack);
            }

            
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            Console.WriteLine(myQueue);
            myQueue.Enqueue(2);
            Console.WriteLine(myQueue);
            myQueue.Enqueue(3);
            Console.WriteLine(myQueue);
            myQueue.Enqueue(4);
            Console.WriteLine(myQueue);
            while (myQueue.Count > 0)
            {
                myQueue.Dequeue();
                Console.WriteLine(myQueue);
            }



            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(6);
            tree.Insert(7);

            tree.InOrderTraversal(tree.RootNode);
            Console.WriteLine("\n");
            tree.PreOrderTraversal(tree.RootNode);
            Console.WriteLine("\n");
            tree.PostOrderTraversal(tree.RootNode);
            Console.WriteLine("\n");



        }

        
    }

    
}
