using System;

namespace Single_Linked_List
{
    class Program
    {
        SingleLinkedList linkedList = new SingleLinkedList();
        static bool exit = false;
        static void Main(string[] args)
        {
            Program program  = new Program();
            while(!exit){
                program.ShowUserGuide();
                int input = Convert.ToInt32(Console.ReadLine());
                program.ExeuteOperationBasedOnInput(input);
            }
            


        }

        private void ShowUserGuide(){
            Console.WriteLine("Please select options for Single Linked List");
            Console.WriteLine("Enter 1 for Creating a new list");
            Console.WriteLine("Enter 2 for Displaying the list");
            Console.WriteLine("Enter 3 for Deleting and item from the list");

        }
        private void ExeuteOperationBasedOnInput(int input){
            switch (input)
            {
                case 1:
                CreateSingleLinkedList();
                break;
                
                case 2: 
                DisplayList();
                break;

                case 3: 
                DeleteItem();
                break;

                default:
                exit = true;
                break;
            }

        }

        private void CreateSingleLinkedList(){
            Console.Write("Enter the size of linked list: ");
            int length = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter item at position {i+1}: ");    
                int value = Convert.ToInt32(Console.ReadLine());
                linkedList.InsertItemAtTheEnd(value);
            }
            Console.WriteLine("\n");
        }

        private void DisplayList(){
            linkedList.DisplayLinkedList(); 
            Console.WriteLine("\n");
        }
         private void DeleteItem(){
            Console.Write("Enter the value you want to delet from the list: ");
            int value = Convert.ToInt32(Console.ReadLine());
            linkedList.DeletItemFromTheList(value); 
            Console.WriteLine("\n");
        }
    }
}
