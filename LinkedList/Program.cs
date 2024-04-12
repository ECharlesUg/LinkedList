namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedlist<int> ll = new SinglyLinkedlist<int>();
            ll.InsertFrontFunction(2);
            ll.InsertFrontFunction(1);
            ll.InsertFrontFunction(4);
            ll.InsertFrontFunction(5);
            ll.InsertFrontFunction(6);
            ll.InsertFrontFunction(7);
            ll.InsertFrontFunction(8);
            ll.InsertFrontFunction(9);
            ll.InsertFrontFunction(10);
            ll.DeleteNodeFunction(5);
            ll.DeleteNodeFunction(6);
            ll.FindMiddleNode();           
        }

    }
}
