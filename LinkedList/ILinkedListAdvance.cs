using System;

namespace DSA.LinkedList
{
    interface ILinkedListAdvance :ILinkedList
    {
        void DeletItemFromTheList(int value);
        void ReverseList();
    }
}