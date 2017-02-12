using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var row = "+";
            var pipe = "|";
            for (int i = 1; i <= n - 2; i++)
            {
                row += " -";
            }
            row += " +";
            Console.WriteLine(row);
            for (int i = 1; i <= n - 2; i++)
            {
                pipe += " -";
            }
            pipe += " |";
            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine(pipe);
            }

            Console.WriteLine(row);
        }
    }
}
