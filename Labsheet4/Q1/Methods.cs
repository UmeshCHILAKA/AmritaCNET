using System;
namespace lab7
{
    class ex4
    {
        static int max(int a, int b)
        {
           return  Math.Max(a, b);
        }
        static double avg(int a, int b)
        {
           return (a + b)/2;
        }
        static int mul(int a, int b)
        {
            return a*b;
        }
        static int celling(double a)
        {
            return Convert.ToInt32( Math.Ceiling(a));
        }
        static void Main()
        {
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine(" max = {0} ", max(i, j));
            Console.WriteLine(" avg = {0} ", avg(i, j));
            Console.WriteLine(" mul = {0} ", mul(i, j));
            Console.WriteLine(" celling = {0} ", celling(i));
        }
    }
}