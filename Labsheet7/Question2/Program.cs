using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();

            // Stack empty
            Console.WriteLine($"Is stack Empty? : {intStack.Count == 0}\r\n");

            intStack.Push(9);
            intStack.Push(18);
            intStack.Push(36);
            intStack.Push(27);

            PrintStack(intStack);

            Console.WriteLine();// Empty line for better view in output

            //Find the top element of the stack and check if the stack is empty or not.
            Console.WriteLine($"Current top element is {intStack.Peek()}");
            PrintStack(intStack);
            Console.WriteLine($"Stack is not affected when peeked.");

            // Stack empty
            Console.WriteLine($"Is stack Empty? : {intStack.Count == 0}\r\n");

            //Reverse stack
            Console.WriteLine($"Reversing the stack");
            var reversedStack=ReverseStack(intStack);
            PrintStack(reversedStack);
            Console.WriteLine();// Empty line for better view in output

            //Ascending sort of Stack
            Console.WriteLine($"Ascendingly Sorted stack");
            var ascendingStack = SortStack(intStack, true);
            PrintStack(ascendingStack);
            Console.WriteLine();// Empty line for better view in output

            //Descending sort of Stack
            Console.WriteLine($"Descendingly Sorted stack");
            var descendingStack = SortStack(ascendingStack, false);
            PrintStack(descendingStack);
            Console.WriteLine();// Empty line for better view in output




            Console.ReadLine();
        }

        /// <summary>
        /// Reverses the stack.
        /// </summary>
        /// <param name="intStack">The int stack.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private static Stack<int> ReverseStack(Stack<int> intStack)
        {
            Stack<int> tempStack = new Stack<int>();
            foreach (var item in intStack)
            {
                tempStack.Push(item);
            }
            return tempStack;
        }

        /// <summary>
        /// Sorts the stack.
        /// </summary>
        /// <param name="intStack">The int stack.</param>
        /// <param name="isAscending">if set to <c>true</c> [is ascending].</param>
        /// <returns>sorted stack</returns>
        private static Stack<int> SortStack(Stack<int> intStack, bool isAscending)
        {
            Stack<int> tempStack = new Stack<int>();

            while (intStack.Count > 0)
            {
                var tempitem = intStack.Pop();

                if (isAscending)
                {
                    while (tempStack.Count > 0 && tempStack.Peek() < tempitem)
                    {
                        intStack.Push(tempStack.Pop());
                    }
                }
                else
                {
                    while (tempStack.Count > 0 && tempStack.Peek() > tempitem)
                    {
                        intStack.Push(tempStack.Pop());
                    }
                }

                tempStack.Push(tempitem);
            }
            return tempStack;
        }

        /// <summary>
        /// Prints the stack.
        /// </summary>
        /// <param name="intStack">The stack.</param>
        private static void PrintStack(Stack<int> intStack)
        {
            if (intStack?.Count > 0)
            {
                Console.WriteLine($"Current Stack is");
                foreach (int num in intStack)
                {
                    Console.Write($"{num} \t");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Current Stack is empty");
            }
        }
    }
}
