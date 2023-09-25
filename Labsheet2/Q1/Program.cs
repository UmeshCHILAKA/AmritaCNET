using System;

namespace Q1
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Please input N:");
                double num = double.Parse(Console.ReadLine());

                if (num - Math.Round(num) == 0)
                    Console.WriteLine($"{num} is an integer.");
                else
                    Console.WriteLine($"{num} is not an integer.");

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
