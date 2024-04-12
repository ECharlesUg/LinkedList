using LinkedList;
using System.Reflection;

class SinglyLinkedlist<T>
{
    private Node<T> head = null;

    public void InsertFrontFunction(T value)
    {
        Node<T> recruit = new Node<T>(value);
        if(head != null)
        {
            head = recruit;
            return;
        }
        recruit.Next = head;
        head = recruit;
    }
    public void InsertLastFunction(T val)
    {
        Node<T> recruit = new Node<T>(val);
        if(head != null)
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = recruit;
        }
        else if (head == null)
        {
            head = recruit;
        }

    }
    public void DeleteNodeFunction(T val)
    {
        Node<T> prev = null;
        Node<T> current = head;
        if (head != null)
        {
            if(head == null)
            {
                return;
            }
            while (current.Next != null && !current.Data.Equals(val))
            {
                prev = current;
                current = current.Next;
            }
            prev.Next = current.Next;
        }

        return;
    }

    public void FindMiddleNode()
    {
        Node<T> current = head;
        Node<T> middle = head;
        if (head != null)
        {
            while (current != null && current.Next != null)
            {
                middle = middle.Next;
                current = current.Next.Next;
                
            }
        }

        Console.WriteLine($"{middle.Data} is the middle Node");
    }       
}
