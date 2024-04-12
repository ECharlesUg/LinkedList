namespace LinkedList
{
    internal class Node<T>
    {
        private T _data;
        private Node<T>? _next;
        public T Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public Node<T>? Next
        {
            get { return _next; }
            set { _next = value; }
        }

        public Node(T value)
        {
            Data = value;
            Next = null;
        }

        public override string ToString()
        {
            return $"[{Data}]";
        }
    }
}
