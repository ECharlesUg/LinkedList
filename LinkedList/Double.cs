using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DoubleNode<T>
    {
        internal T Data { get; set; }
        internal DoubleNode<T>? Next { get; set; }
        internal DoubleNode<T>? Prev { get; set; }

        public DoubleNode() { }
        public DoubleNode(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
        public DoubleNode(T data, DoubleNode<T> next)
        {
            Data = data;
            Next = next;
            Prev = null;
        }
        public DoubleNode(T data, DoubleNode<T> next, DoubleNode<T> prev)
        {
            Data = data;
            Next = next;
            Prev = prev;
        }

    }
    
}
