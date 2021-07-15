using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ShowOptions();
            Console.WriteLine("Enter your options: ");
            int value = Int32.Parse(Console.ReadLine());
        }

        private void ShowOptions(){
            Console.WriteLine("===============Choose options to perform actions===============");
            Console.WriteLine("Single Linked List: 1");
            Console.WriteLine("Double Linked List: 2");
            Console.WriteLine("Circular Linked List: 3");
            Console.WriteLine("Sorted Linked List: 3");
        }

    }
}
