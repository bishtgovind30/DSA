using System;

namespace DSA.SortedLinkedList
{
    class SortedLinkedList
    {
        private Node headNode;

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

        public void DisplayList(){
            Node currentNode = headNode;
            while (currentNode!=null)
            {
                Console.Write(currentNode.data +" ");
                currentNode = currentNode.next;
            }
        }
    }
}