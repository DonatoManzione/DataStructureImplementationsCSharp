﻿using System;
namespace DataStructures
{
    public class Stack<E>
    {
        private DoublyLinkedList<E> InnerList { get; set; }
        public int Count { get; set; }

        public Stack()
        {
            InnerList = new DoublyLinkedList<E>();
            Count = 0;
        }

        public void Push(E data)
        {
            InnerList.Add(data);
            Count++;
        }

        public E Pop()
        {
            Count--;
            if (InnerList.Count == 0)
            {
                throw new EmptyStackException();
            }else
            {
                E returnVal = InnerList.Last.Data;

                if (InnerList.Last.Previous != null)
                {
                    InnerList.Last = InnerList.Last.Previous;
                    InnerList.Last.Next = null;
                }else
                {
                    InnerList.Last = null;
                    InnerList.First = null;
                    
                }
                
                return returnVal;
            }
           
        }



    }
}
