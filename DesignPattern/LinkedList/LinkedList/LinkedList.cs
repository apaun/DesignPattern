using System;

namespace LinkedList
{
    public class LinkedList
    {
        private int Data { get; set; }
        private LinkedList Next { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="data"></param>
        /// <param name="next"></param>
        public LinkedList(int data, LinkedList next = null)
        {
            Data = data;
            Next = next;
        }

        public LinkedList AddStart(int data)
        {
            var node = new LinkedList(data) {Next = this};
            return node;
        }

        public void AddEnd(int data)
        {
            var node = this;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = new LinkedList(data, null);
        }

        public int Length()
        {
            var length = 0;
            var node = this;
            while (node != null)
            {
                length++;
                node = node.Next;
            }

            return length;
        }

        public int GetMiddle()
        {
            var slowPtr = this;
            var fastPtr = this;
            while (fastPtr?.Next != null)
            {
                slowPtr = slowPtr.Next;
                fastPtr = fastPtr.Next.Next;
            }

            return slowPtr.Data;
        }

        public LinkedList DeleteNode(int data)
        {
            var tempHead = this;
            if (tempHead.Data == data)
            {
                tempHead.Next = tempHead.Next;
            }

            return tempHead;
        }

        public void PrintList()
        {
            var node = this;
            while (node != null)
            {
                Console.Write(node.Data + " ");
                node = node.Next;
            }
            Console.WriteLine();
        }

        public LinkedList Reverse(LinkedList node)
        {
            if (node == null)
                return null;

            LinkedList prev = null;
            LinkedList curr = node;

            while (curr != null)
            {
                var next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }

            return prev;

        }

    }
}
