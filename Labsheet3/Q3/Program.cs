using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                /*
     Enter a shipping type (R-Regular, X-Express): R
Enter the weight of your book package (kilograms): 4.5
Your shipping cost is 1375.00 bahts with R-type shipping of 4.5-kilogram book

     */
                Console.Write("Enter a shipping type (R-Regular, X-Express): ");
                var type = Console.ReadKey().KeyChar;
                var cost = 0.0;
                if (type == 'R' || type == 'X')
                {
                    Console.Write("\r\nEnter the weight of your book package (kilograms): ");
                    var weight = Convert.ToDouble(Console.ReadLine()) * 1000;
                    if (weight <= 2000)
                    {
                        cost = weight * 0.25;
                    }
                    else
                    {
                        const double fixedRate = 2000 * 0.25;
                        cost = fixedRate + (weight - 2000) * 0.35;
                    }
                    if (type == 'X')
                    {
                        cost += 50;
                    }
                    Console.WriteLine($"\r\nYour shipping cost is {cost} bahts with {type}-type shipping of {weight / 1000}-kilogram books");
                }
                else
                {
                    Console.WriteLine("\r\nYour type is invalid!!");
                }
                Console.WriteLine("\r\n"); 
            }
        }
    }
}
