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

        public void DeletItemFromTheList(int value){
            if(head == null){
                Console.WriteLine("List is empty");
                return;
            }
            else if(head.data == value){
                head = head.next;
                return;
            }

            Node currentNode = head;
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
    }
}