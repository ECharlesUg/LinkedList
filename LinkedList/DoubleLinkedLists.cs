namespace LinkedList
{
    internal class DoubleLinkedLists<T>
    {
        internal DoubleNode<T>? head = null;
        internal DoubleNode<T>? tail = null;
        DoubleNode<T> node;
        public void InsertFront(T value)
        {
            node = new DoubleNode<T>(value);
            if (head == null)
            {
                head = node;
                tail = node;
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
            }
            tail.Next = node;
            node.Prev = tail;
            tail = node;
        }

        public void DeleteNode(T value)
        {
            DoubleNode<T> current = head;
            if (current == null)
            {
                return;
            }
            while (current != null)
            {
                if (current.Data.Equals(value))
                {
                    // Case 1
                    if (current == head)
                    {
                        head = current.Next;
                        if (head == null)
                        {
                            tail = null;
                        }
                        return;
                    }

                    // Case 2
                    else if (current == tail)
                    {
                        tail = current.Prev;
                        return;
                    }

                    // Case 3
                    if (current.Prev != null)
                    {
                        current.Prev.Next = current.Next;
                    }
                    if (current.Next != null)
                    {
                        current.Next.Prev = current.Prev;
                    }
                    return; 
                }
                current = current.Next;
            }
        }
        public void IsPalindrome()
        {
            DoubleNode<T> a = head;
            DoubleNode<T> b = tail;

            while (a != null && b != null && a != b)
            {
                if (!a.Data.Equals(b.Data))
                {
                    Console.WriteLine("Is not a palindrome");
                    return;
                }
                a = a.Next;
                b = b.Prev;
            }

            Console.WriteLine("Is a palindrome");

        }

    }
}