using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        private static void PrintColumns(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }

            Console.WriteLine();
        }

        private static void PrintTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                PrintColumns(row);
            }

            for (int row = number - 1; row >= 1; row--)
            {
                PrintColumns(row);
            }
        }
    }
}
