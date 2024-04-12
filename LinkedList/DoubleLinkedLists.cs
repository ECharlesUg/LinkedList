using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal class DoubleLinkedLists<T>
    {
        internal DoubleNode<T>? head;
        internal DoubleNode<T>? tail;
        DoubleNode<T> node;
        public DoubleLinkedLists(T value)
        {
            head = null;
            tail = null;
            node = new DoubleNode<T>(value);
            head = node;
            tail = node;
        }
        public void InsertFront(T value)
        {
            node = new DoubleNode<T>(value);
            if (head == null)
            {
                head = node;
                tail = node;
                return;
            }
            node.Next = head;
            head = node;

        }

        public void InsertBack(T value)
        {
            node = new DoubleNode<T>(value);
            if (tail == null)
            {
                tail = node;
                head = node;
                return;
            }
            tail.Next = head;
            tail = node;
        }

        public void DeleteNode(T value)
        {
            DoubleNode<T> current = head;
            if (current == null)
            {
                return;
            }
            while (current != tail)
            {
                if (current.Data.Equals(value))
                {
                    current.Prev.Next = current.Next;
                }
                current = current.Next;
            }
            return; //P O O P // A=A.NEXT (GOES FOWARD) // B = B.PREV (GOES BACKWARD)  //A.DATA.EQUALS(B.DATA) CHECKS IF CONDITION IS TRUE
        }

      
 
    }
}
