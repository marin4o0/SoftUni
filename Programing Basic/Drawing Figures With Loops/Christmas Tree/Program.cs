using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int j = 0; j <= n; j++)
            {
                Console.Write(new string(' ', n - j) + new string('*', j) + " " + "|" + " " + new string('*', j) + new string(' ', n - j));
                Console.WriteLine();
            }

        }
    }
}
