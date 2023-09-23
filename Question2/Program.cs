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
            Console.WriteLine($"Is stack Empty? : {intStack.Count==0}\r\n");


            //Ascending sort of Stack
            Console.WriteLine($"Ascendingly Sorted stack");
            SortStack(intStack, true);
            PrintStack(intStack);


            //Ascending sort of Stack
            Console.WriteLine($"Descendingly Sorted stack");
            SortStack(intStack, false);
            PrintStack(intStack);
            Console.ReadLine();
        }

        private static void SortStack(Stack<int> intStack, bool isAscending)
        {
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
