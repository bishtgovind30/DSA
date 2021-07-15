using System;

namespace LinkedList
{
    class Program
    {
        static LinkedListFactory factory;
        static bool exitListOperation= false;
        static bool exitMainOperation= false;
        static void Main(string[] args)
        {
            Program program = new Program();
            while(!exitMainOperation){
            program.ShowOptions();
            Console.WriteLine("Enter your options: ");
            int value = Int32.Parse(Console.ReadLine());
            factory = new LinkedListFactory(value);
            program.ExecuteMainOperation(value);
            }
        }

        private void ShowOptions(){
            Console.WriteLine("===============Choose options to perform actions===============");
            Console.WriteLine("Single Linked List: 1");
            Console.WriteLine("Double Linked List: 2");
            Console.WriteLine("Circular Linked List: 3");
            Console.WriteLine("Sorted Linked List: 4");
            Console.WriteLine("To Exit: 5");
        }

         private void ExecuteMainOperation(int option){
            switch (option)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                LinkedListOperations();
                exitListOperation = false;
                break;
                default:
                exitMainOperation = true;
                break;
            }
        }

        private void LinkedListOperations(){
            while(!exitListOperation){
                factory.LinkedList.ShowOptions();
                int option = Int32.Parse(Console.ReadLine());
                ExecuteOperations(option);
            }
        }
        private void ExecuteOperations(int option){
            switch (option)
            {
                case 1:
                CreateList();
                break;
                case 2:
                DisplayList();
                break;
                case 3:
                DeleteItemFromList();
                break;
                case 4:
                ReverseList();
                break;
                default:
                exitListOperation = true;
                break;
            }
        }

        private void CreateList(){
            Console.Write("Enter the size of linked list: ");
            int length = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter item at position {i+1}: ");    
                int value = Convert.ToInt32(Console.ReadLine());
                factory.LinkedList.InsertItemInTheList(value);
            }
            Console.WriteLine("\n");
        }
        private void DisplayList(){
            factory.LinkedList.DisplayList(); 
            Console.WriteLine("\n");
        }
        private void DeleteItemFromList(){
            Console.Write("Enter the value you want to delete from the list: ");
            int value = Convert.ToInt32(Console.ReadLine());
            factory.LinkedList.DeletItemFromTheList(value); 
            Console.WriteLine("\n");
        }
        private void ReverseList(){
            factory.LinkedList.ReverseList(); 
            Console.WriteLine("\n");
        }

    }
}
