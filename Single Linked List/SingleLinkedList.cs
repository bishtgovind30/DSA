using System;

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
    }
}
