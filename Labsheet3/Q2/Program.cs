using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string data = "";
            //for (int i = 0; i < 26; i++)
            //{
            //    data += $"case '{(char)(i+65)}':\r\n";
            //    data += $"case '{(char)(i+97)}':\r\n";
            //}
            Console.Write("Please input a letter: ");
            var input = Console.ReadKey();
            Console.WriteLine();
            int num = 0;
            switch (input.KeyChar)
            {
                case 'A':
                case 'a':
                case 'B':
                case 'b':
                case 'C':
                case 'c':
                    num = 2; break;
                case 'D':
                case 'd':
                case 'E':
                case 'e':
                case 'F':
                case 'f':
                    num = 3; break;
                case 'G':
                case 'g':
                case 'H':
                case 'h':
                case 'I':
                case 'i':
                    num = 4; break;
                case 'J':
                case 'j':
                case 'K':
                case 'k':
                case 'L':
                case 'l':
                    num = 5; break;
                case 'M':
                case 'm':
                case 'N':
                case 'n':
                case 'O':
                case 'o':
                    num = 6; break;
                case 'P':
                case 'p':
                case 'Q':
                case 'q':
                case 'R':
                case 'r':
                case 'S':
                case 's':
                    num = 7; break;
                case 'T':
                case 't':
                case 'U':
                case 'u':
                case 'V':
                case 'v':
                    num = 8; break;
                case 'W':
                case 'w':
                case 'X':
                case 'x':
                case 'Y':
                case 'y':
                case 'Z':
                case 'z':
                    num = 9; break;
                default: num = -1; break;
            }
            Console.WriteLine($"The corresponding number of {input.KeyChar} is {num}.");
        }
    }
}
