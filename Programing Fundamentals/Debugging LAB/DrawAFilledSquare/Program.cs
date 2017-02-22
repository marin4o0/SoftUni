using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            PrintHeaderRow(number);
            PrintBody(number);
            PrintHeaderRow(number);
        }

        private static void PrintHeaderRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }

        private static void PrintBody(int number)
        {
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j < number; j++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine("-");
            }
        }
    }
}
