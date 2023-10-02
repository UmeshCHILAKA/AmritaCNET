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
            Task2_2();
            Console.ReadLine();
            return;
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

        /// <summary>
        /// Ex1s the 3.
        /// </summary>
        public static void Ex1_3()
        {
            int sum = 0;
            int input = 0;
            while (input >= 0)
            {
                Console.Write("Please input number N: ");
                if (input % 2 == 0)
                {
                    sum += input;
                }
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of all even numbers entered (excluding negative number): " + sum);
            Console.WriteLine("Bye. Bye!!!");
        }

        public static void EX2_1()
        {
            int sum = 0;
            int input;

            do
            {
                Console.Write("Please input number N: ");
                input = int.Parse(Console.ReadLine());

                if (input >= 0)
                {
                    sum += input;
                }
            } while (input >= 0);

            Console.WriteLine("Sum of all numbers (except last one) entered: " + sum);
            Console.WriteLine("Bye. Bye!!!");
        }

        public static void Task3_1()
        {
            int count = 0;
            double totalScore = 0;

            Console.WriteLine("Enter student scores. Enter -1 to quit.");
            double input = 0;
            while (input != -1)
            {
                Console.Write("Enter score : ");
                if (double.TryParse(Console.ReadLine(), out input))
                {
                    if (input == -1)
                        break;

                    totalScore += input;
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"Number of students: {count}");
                Console.WriteLine($"Average score: {totalScore / count:F2}");
            }
            else
            {
                Console.WriteLine("No valid scores entered.");
            }
        }

        public static void Task3_2()
        {
            int count = 0;
            double totalScore = 0;
            double minScore = double.MaxValue;
            double maxScore = double.MinValue;

            while (true)
            {
                Console.Write("Enter student score (or -1 to stop): ");

                if (!double.TryParse(Console.ReadLine(), out double score))
                {
                    Console.WriteLine("Invalid input. Please enter a valid score.");
                    continue;
                }

                if (score == -1) { break; }

                totalScore += score;
                count++;

                minScore = Math.Min(minScore, score);
                maxScore = Math.Max(maxScore, score);
            }

            if (count > 0)
            {
                Console.WriteLine($"Number of students: {count}");
                Console.WriteLine($"Minimum score: {minScore:F2}");
                Console.WriteLine($"Maximum score: {maxScore:F2}");
                Console.WriteLine($"Average score: {totalScore / count:F2}");
            }
            else
            {
                Console.WriteLine("No valid scores entered.");
            }
        }

        public static void Task1_2
            ()
        {
            Console.WriteLine("Enter the elements of the 2x2 matrix:");
            Console.Write("Enter element 1X1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter element 1X2: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter element 2X1: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter element 2X2: ");
            double d = double.Parse(Console.ReadLine());

            double determinant = (a * d) - (b * c);

            Console.WriteLine("Determinant of the matrix is: " + determinant);

        }
        public static void Task2_2()
        {
            Console.WriteLine("Enter elements for Matrix A:");
            double[,] matrixA = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Enter A[{0},{1}]: ", i + 1, j + 1);
                    matrixA[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements for Matrix B:");
            double[,] matrixB = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Enter B[{0},{1}]: ", i + 1, j + 1);
                    matrixB[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double[,] matrixC = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrixC[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            Console.WriteLine("Result Matrix C:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0,8}", matrixC[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
