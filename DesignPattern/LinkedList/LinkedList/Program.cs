using System;

namespace LinkedList
{
    internal static class Program
    {
        static void Main()
        {

            var head = new LinkedList(10);
            head.AddEnd(20);
            head.AddEnd(30);
            head = head.AddStart(5).AddStart(1);
            head.PrintList();
            Console.WriteLine("Length of Linked list : " + head.Length());
            Console.WriteLine("Middle Node : " + head.GetMiddle());

            head = head.Reverse(head);
            Console.WriteLine("After Reverse : ");
            head.PrintList();
        }
    }
}
