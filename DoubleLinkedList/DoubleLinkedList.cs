using System;

namespace DSA.DoubleLinkedList
{
    class DoubleLinkedList
    {
        Node head;

        public void InsertItemAtBegining(int value)
        {
            Node nodeToAdd = new Node(value);
            nodeToAdd.next = head;
            head.previous = nodeToAdd;
            head = nodeToAdd;
        }

        public void InsertItemAtTheEnd(int value)
        {
            Node nodeToAdd = new Node(value);
            if(head == null)
            {
                head = nodeToAdd;
                return;
            }
            Node currentNode = head;
            while (currentNode.next!=null)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = nodeToAdd;
            nodeToAdd.previous = currentNode;
        }
        public void DisplayList()
        {
            if(head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            
            Node currentNode = head;
            while (currentNode!=null)
            {
                Console.Write(currentNode.data + " ");
                currentNode=currentNode.next;
            }
        }
    }
}