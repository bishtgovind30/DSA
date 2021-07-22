using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace Problems
{
    public class ExpressionsValidator
    {
        public bool IsValidExpression(string expression){
            char [] charArrayToPush = new char[3]{'[','{','('};
            char [] charArrayToPop = new char[3]{']','}',')'};
            Dictionary<char,char> parenthesisMapping = new Dictionary<char, char>(){
                {']','['},{'}','{'},{')','('},
            };
            Stack stack = new Stack();
            foreach (var character in expression)
            {
                if(charArrayToPush.Contains(character))
                    stack.Push(character);
                else if(charArrayToPop.Contains(character))
                {
                    var parenthesis = stack.Pop();
                    if(!parenthesisMapping[character].Equals(parenthesis))
                        return false;
                }
            }
            if(stack.Count ==0)
                return true;
            else
                return false;

        }
    }
}