using System;
using DSA.LinkedList;
using LinkedList.Model;

namespace LinkedList.BL
{
    class DoubleLinkedList : ILinkedList
    {
        private DoubleNode headNode;
        public void DeletItemFromTheList(int value)
        {
            if(headNode == null){
                Console.WriteLine("List is empty");
                return;
            }
            else if(headNode.data == value){
                headNode = headNode.next;
                return;
            }

            DoubleNode currentNode = headNode;
            while (currentNode.next!=null)
            {
                if(currentNode.data == value)
                break;
                
                currentNode=currentNode.next;
            }

            if(currentNode.next!=null){
                currentNode.previous.next = currentNode.next;
                currentNode.next.previous = currentNode.previous;
            }
            else{
                if(currentNode.data == value)
                    currentNode.previous.next = null;
                else 
                    Console.WriteLine("Element not found in the list");
            }
        }

        public void DisplayList()
        {
            if(headNode == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }
            
            DoubleNode currentNode = headNode;
            while (currentNode!=null)
            {
                Console.Write(currentNode.data + " ");
                currentNode=currentNode.next;
            }
        }

        public void InsertItemInTheList(int value)
        {
            DoubleNode nodeToAdd = new DoubleNode(value);
            if(headNode == null)
            {
                headNode = nodeToAdd;
                return;
            }
            DoubleNode currentNode = headNode;
            while (currentNode.next!=null)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = nodeToAdd;
            nodeToAdd.previous = currentNode;
        }

        public void ReverseList()
        {
            DoubleNode currentNode = headNode;
            DoubleNode nextNode = currentNode.next;
            currentNode.next = null;
            currentNode.previous = nextNode;

            while (nextNode!=null)
            {
                nextNode.previous = nextNode.next;
                nextNode.next = currentNode;
                currentNode = nextNode;
                nextNode = nextNode.previous;
            }
            headNode = currentNode;
        }

        void ILinkedList.ShowOptions()
        {
            Console.WriteLine("Please select options for Double Linked List");
            Console.WriteLine("Enter 1 for Creating a new list");
            Console.WriteLine("Enter 2 for Displaying the list");
            Console.WriteLine("Enter 3 for Deleting and item from the list");
            Console.WriteLine("Enter 4 for Reversing the list");
        }
    }
}