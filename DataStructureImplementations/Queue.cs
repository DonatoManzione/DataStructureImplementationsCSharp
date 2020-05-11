﻿using System;
namespace DataStructures
{
    public class Queue<E>
    {
        private DoublyLinkedList<E> InnerList { get; set; }
        public int Count { get { return InnerList.Count; } }
        public Queue()
        {
            InnerList = new DoublyLinkedList<E>();

        }
        public void Enqueue(E data)
        {

            DoublyLinkedListNode<E> newNode = new DoublyLinkedListNode<E>(data); //Create new node from data

            //Account for when there are no elements in the list yet
            //first is null, last is null, count is 0...
            if (InnerList.Count == 0)
            {
                InnerList.Head = InnerList.Tail = newNode; //...in that case, the first and last node will be the same: the new node
                InnerList.Count = 1; //add 1 to the count variable
            }

            //Account for when there is only one element in the list
            //first and last are the same, count is 1
            else if (InnerList.Count == 1)
            {
                //we are adding the element at the front of the list, so First becomes our newNode
                InnerList.Head = newNode;
                //because there are more than one node now, the Next and Previous pointers can't point to null anymore
                InnerList.Head.Next = InnerList.Tail; //With only two nodes, the second is the last, and we already had it set up
                InnerList.Tail.Previous = InnerList.Head; //adjust references -- Last's Previous pointer should point to the first node
                InnerList.Count++;//add 1 to the count variable
            }
            else
            {
                DoublyLinkedListNode<E> temp = InnerList.Head; //Save the current first node in a temporary variable for later use
                InnerList.Head = newNode; // Make the new node the new first node
                InnerList.Head.Next = temp; //Make the old first node the new second node
                temp.Previous = InnerList.Head; //adjust references - Now temp's Previous is not null, but the new first
                InnerList.Head.Previous = null; //adjust references - Now newNode's Previous is null, as it is the first node
                InnerList.Count++;//adjust the count variable to account for one more node
            }

        }
        public E Dequeue()
        {
            E lastNodeData = InnerList.Tail.Data;//Put the last node's data into a temporary variable to return later
            if (InnerList.Count == 0) //account for if the queue is empty
            {
                throw new EmptyQueueException();
            }
            else if (InnerList.Count == 1)//if there is only one element left, be sure to make both first and last null
            {
                InnerList.Head = null;
                InnerList.Tail = null;
                InnerList.Count = 0;
            }
            else
            {

                InnerList.Tail = InnerList.Tail.Previous; //change Last var so it will hold the former second-to-last node
                InnerList.Tail.Next = null; //adjust references - Now the new Last node's Next pointer will point to null
                InnerList.Count--; //adjust the count variable to account for one more node
            }
            return lastNodeData;

        }
    }
}
