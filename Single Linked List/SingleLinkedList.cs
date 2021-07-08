using System;
using System.Collections;

namespace Single_Linked_List{
    class SingleLinkedList{
        private Node start;
        public void InsertItemInBegining(int value){
            Node node = new Node(value);
            node.next = start;
            start = node;
        }

        public void InsertItemAtTheEnd(int value){
            Node nodeToAdd = new Node(value);
            if(start == null){
                start = nodeToAdd;
                return;
            }
            Node currentNode = start;
            while(currentNode.next!=null){
                currentNode = currentNode.next;
            }

            
            currentNode.next = nodeToAdd;
        }
    
        public void DisplayLinkedList(){
            if(start == null)
            {
                Console.WriteLine("List is empty");
            }
            Node currentNode = start;
            while(currentNode !=null){
                Console.Write(currentNode.data+ " ");
                currentNode = currentNode.next;
            }
        }    

        public void DeletItemFromTheList(int value){
            if(start == null){
                Console.WriteLine("List is empty");
                return;
            }

            if(start.data == value){
                start = start.next;
                return;
            }
            Node previous = start;
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
    
        public void ReverseList(){
            Node previousNode = null;
            Node current = start;
            Node nextNode;
            while (current!=null)
            {
                nextNode = current.next;
                current.next = previousNode;
                previousNode = current;
                current = nextNode;
            }
            start= previousNode;
        }
    }
}
