using System;

namespace DSA.DoubleLinkedList
{
    class Node
    {
        public Node previous;
        public Node next;
        public int data;

        public Node(int data)
        {
            this.data = data;
        }
    }
}