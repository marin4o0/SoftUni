using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ', i) + "*");
                for (int j = n - i; j > 1; j--)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
