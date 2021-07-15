using System;
using DSA.LinkedList;
using LinkedList.Model;

namespace LinkedList.BL
{
    class SortedLinkedList : ILinkedList
    {
        private Node headNode;

        public void DeletItemFromTheList(int value)
        {
            throw new NotImplementedException();
        }

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

        public void ReverseList()
        {
            throw new NotImplementedException();
        }

        void ILinkedList.ShowOptions()
        {
            Console.WriteLine("Please select options for Circular Linked List");
            Console.WriteLine("Enter 1 for Creating a new list");
            Console.WriteLine("Enter 2 for Displaying the list");
            Console.WriteLine("Enter 3 for Deleting and item from the list");
            Console.WriteLine("Enter 4 for Reversing the list");
        }
    }
}