using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = b;
            int d = a;

            Console.WriteLine(@"Before:
a = {0}
b = {1}", a, b);

            Console.WriteLine(@"After:
a = {0}
b = {1}", c, d);
        }
    }
}
