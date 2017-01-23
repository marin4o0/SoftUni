using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                int sum = 0;
                int digits = num;
                while (digits > 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }
                bool special = (sum == 5 || sum == 7 || sum == 11);
                Console.WriteLine($"{num} -> {special}");
            }

        }
    }
}
