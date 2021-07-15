using System;
using DSA.LinkedList;
using LinkedList.Model;

namespace LinkedList.BL
{
    class CircularLinkedList : ILinkedList
    {
        private Node lastNode;

        public void DeletItemFromTheList(int value)
        {
            throw new NotImplementedException();
        }

        public void DisplayList()
        {
            if(lastNode == null)
            {
                Console.WriteLine("List is empty");
            }
            
            Node currentNode= lastNode.next;
            while (currentNode!=lastNode)
            {
                Console.Write(currentNode.data+ " ");
                currentNode=currentNode.next;
            }
            Console.Write(lastNode.data+ " ");
        }

        public void InsertItemInTheList(int value)
        {
            Node nodeToAdd = new Node(value);
            if(lastNode == null){
                lastNode = nodeToAdd;
                lastNode.next = lastNode;
            }
            else{
                nodeToAdd.next = lastNode.next;
                lastNode.next = nodeToAdd;
                lastNode = nodeToAdd;
            }
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