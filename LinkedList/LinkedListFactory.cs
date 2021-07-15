using DSA.LinkedList;
using LinkedList.BL;

namespace LinkedList
{
    public class LinkedListFactory
    {
        private ILinkedList _linkedList;
        public LinkedListFactory(int typeOfLinkedList)
        {
            SetLinkedListInstance(typeOfLinkedList);
        }

        public ILinkedList LinkedList { get => _linkedList;}

        public void SetLinkedListInstance(int value){
            switch (value)
            {
                case 1:
                _linkedList= new SingleLinkedList();
                break;
                case 2: 
                _linkedList= new DoubleLinkedList();
                break;
                case 3:
                _linkedList= new CircularLinkedList();
                break;
                case 4:
                _linkedList= new SortedLinkedList();
                break;
                default:
                _linkedList= null;
                break;
            }
        }
    }

}