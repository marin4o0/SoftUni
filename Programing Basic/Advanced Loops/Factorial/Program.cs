using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var Factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                Factorial *= i;
            }
            Console.WriteLine(Factorial);
        }
    }
}
