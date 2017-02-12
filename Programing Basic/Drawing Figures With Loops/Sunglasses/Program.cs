using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
            Console.WriteLine();
            for (int i = 1; i < n - 2; i++)
            {

                if (i == n - 1 || i == 2 - 1)
                {
                    Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" + new string('|', n) + "*" + new string('/', 2 * n - 2) + "*");
                }
                Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" + new string(' ', n) + "*" + new string('/', 2 * n - 2) + "*");
            }
            Console.Write(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
            Console.WriteLine();
        }
    }
}
