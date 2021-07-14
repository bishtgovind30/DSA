using System;
namespace DSA.CircularLinkedList
{
    class CircularLinkedList
    {
        private Node last;

        public void InsertItemAtBegining(int value){
            Node nodeToadd = new Node(value);
            nodeToadd.next = last.next;
            last.next = nodeToadd;
        }
        public void InsertItemAtTheEnd(int value){
            Node nodeToAdd = new Node(value);
            if(last == null){
                last = nodeToAdd;
                last.next = last;
            }
            else{
                nodeToAdd.next = last.next;
                last.next = nodeToAdd;
                last = nodeToAdd;
            }

        }

        public void DisplayList(){
            Node currentNode= last.next;
            while (currentNode!=last)
            {
                Console.Write(currentNode.data+ " ");
                currentNode=currentNode.next;
            }
            Console.Write(last.data+ " ");
        }
    }
}