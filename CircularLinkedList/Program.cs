﻿using System;

namespace DSA.CircularLinkedList
{
    class Program
    {
        CircularLinkedList circularLinkedList = new CircularLinkedList();
        static bool exit=false;
        static void Main(string[] args)
        {
            Program program  = new Program();
            while(!exit){
                program.ShowUserGuide();
                int input = Convert.ToInt32(Console.ReadLine());
                program.ExeuteOperationBasedOnInput(input);
            }
        }

         private void ShowUserGuide()
        {
            Console.WriteLine("Please select options for Circular Linked List");
            Console.WriteLine("Enter 1 for Creating a new list");
            Console.WriteLine("Enter 2 for Displaying the list");
            Console.WriteLine("Enter 3 for Deleting and item from the list");
            Console.WriteLine("Enter 4 for Reversing the list");

        }

        private void ExeuteOperationBasedOnInput(int input){
            switch (input)
            {
                case 1:
                CreateDoubleLinkedList();
                break;
                
                case 2: 
                DisplayList();
                break;

                // case 3: 
                // DeleteItem();
                // break;

                // case 4: 
                // ReverseList();
                // break;

                default:
                exit = true;
                break;
            }

        }

        private void CreateDoubleLinkedList(){
            Console.Write("Enter the size of linked list: ");
            int length = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter item at position {i+1}: ");    
                int value = Convert.ToInt32(Console.ReadLine());
                circularLinkedList.InsertItemAtTheEnd(value);
            }
            Console.WriteLine("\n");
        }

        private void DisplayList(){
            circularLinkedList.DisplayList();
            Console.WriteLine("\n");
        }
    }
}