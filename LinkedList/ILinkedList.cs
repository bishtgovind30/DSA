using System;

namespace DSA.LinkedList
{
    public interface ILinkedList{
        void InsertItemInTheList(int value);
        void DisplayList();
        void ShowOptions();
        void DeletItemFromTheList(int value);
        void ReverseList();
    }

}