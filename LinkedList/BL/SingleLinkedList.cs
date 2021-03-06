using System;
using DSA.LinkedList;
using LinkedList.Model;

namespace LinkedList.BL
{
    class SingleLinkedList : ILinkedList
    {
        private Node startNode;

        public void DeletItemFromTheList(int value)
        {
            if(startNode == null){
                Console.WriteLine("List is empty");
                return;
            }

            if(startNode.data == value){
                startNode = startNode.next;
                return;
            }
            Node previous = startNode;
            while(previous.next!= null){
                if(previous.next.data == value){
                    previous.next = previous.next.next;
                    previous = previous.next;
                    return;
                }
                previous = previous.next;
            }

            Console.WriteLine("Element not found in the list");
        }

        public void DisplayList()
        {
            if(startNode == null)
            {
                Console.WriteLine("List is empty");
            }
            Node currentNode = startNode;
            while(currentNode !=null){
                Console.Write(currentNode.data+ " ");
                currentNode = currentNode.next;
            }
        }

        public void InsertItemInTheList(int value)
        {
            Node nodeToAdd = new Node(value);
            if(startNode == null){
                startNode = nodeToAdd;
                return;
            }
            Node currentNode = startNode;
            while(currentNode.next!=null){
                currentNode = currentNode.next;
            }           
            currentNode.next = nodeToAdd;
        }

        public void ReverseList()
        {
            Node previousNode = null;
            Node current = startNode;
            Node nextNode;
            while (current!=null)
            {
                nextNode = current.next;
                current.next = previousNode;
                previousNode = current;
                current = nextNode;
            }
            startNode= previousNode;
        }

        public void ShowOptions()
        {
            Console.WriteLine("Please select options for Single Linked List");
            Console.WriteLine("Enter 1 for Creating a new list");
            Console.WriteLine("Enter 2 for Displaying the list");
            Console.WriteLine("Enter 3 for Deleting and item from the list");
            Console.WriteLine("Enter 4 for Reversing the list");
        }
    }
}