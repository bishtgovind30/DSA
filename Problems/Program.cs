using System;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            while (true)
            {
                p.ShowOptions();
                int option = Convert.ToInt32(Console.ReadLine());
                p.ExecuteOperations(option);
            }
        }

        private void ShowOptions(){
            Console.WriteLine("=====Choose your problem=====");
            Console.WriteLine("Enter 1: Checking Validtity Of Expression Conatining Nested Parenthesis");

        }

        private void ExecuteOperations(int option){
            switch (option)
            {
                case 1:
                ValidateExpression();
                break;
                default:
                break;
            }
        }

        private void ValidateExpression(){
            ExpressionsValidator validator = new ExpressionsValidator();
            Console.Write("Enter parenthesis expression you want to validate: ");
            string expression = Console.ReadLine();
            bool isValid = validator.IsValidExpression(expression);
            var message = isValid? "Expression is Valid" : "Expression is Invalid";
            Console.WriteLine(message);
            Console.WriteLine("\n");
        }
    }
}
