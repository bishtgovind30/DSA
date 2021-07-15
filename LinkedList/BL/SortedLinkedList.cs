using System;
using DSA.LinkedList;
using LinkedList.Model;

namespace LinkedList.BL
{
    class SortedLinkedList : ILinkedList
    {
        private Node headNode;
        public void DisplayList()
        {
            if(headNode == null)
            {
                Console.WriteLine("List is empty");
            }
            Node currentNode = headNode;
            while (currentNode!=null)
            {
                Console.Write(currentNode.data +" ");
                currentNode = currentNode.next;
            }
        }

        public void InsertItemInTheList(int value)
        {
            Node nodeToAdd= new Node(value);
            if(headNode == null){
                headNode = nodeToAdd;
                return;
            }
            Node currentNode = headNode;
            while (currentNode.next!=null && currentNode.next.data <=value)
            {
                currentNode = currentNode.next;
            }
            nodeToAdd.next = currentNode.next;
            currentNode.next = nodeToAdd;
        }
    }
}