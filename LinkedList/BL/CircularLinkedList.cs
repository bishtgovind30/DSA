using System;
using DSA.LinkedList;
using LinkedList.Model;

namespace LinkedList.BL
{
    class CircularLinkedList : ILinkedList
    {
        private Node lastNode;
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
    }
}