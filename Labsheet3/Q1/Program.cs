using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int add_up;
            double cost = 35.0;
            Console.WriteLine("You .can .add .into .your.coffee .with .either:");
            Console.WriteLine(".1-Milk ,.2-Sugar,.3-Milk + Sugar,.4-Nothing ");
            Console.Write("Your.choice .is:.");
            add_up = int.Parse(Console.ReadLine());
            switch (add_up)
            {
                case 1:
                    cost += 9.00;
                    break;
                case 2:
                    cost += 5.00;
                    break;
                case 3:
                    cost += 12.00;
                    break;
                case 4:
                    cost += 0.0;
                    break;
                default:
                    Console.WriteLine("Your coffee is canceled.");
                    cost = -1;
                    break;
            }
            if (cost>0)
            {
                Console.WriteLine("Your.coffee cost.is.{0}.baht.", cost);
                Console.WriteLine("Thank.you."); 
            }
        }
    }
}
