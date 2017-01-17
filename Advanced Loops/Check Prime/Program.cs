using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var factorial = 1;
            var mynumber = 0;
            if (number < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 1; i < number; i++)
                {
                    factorial *= i;
                }
                mynumber = factorial + 1;
                if (mynumber % number == 0)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
        }
    }
}
