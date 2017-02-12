using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var sum1 = 0;
            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum += number;
                }
                if (!(i % 2 == 0))
                {
                    sum1 += number;
                }
            }
            if (sum == sum1)
            {
                Console.WriteLine("Yes Sum = " + sum);
            }
            else if (sum != sum1)
            {
                Console.WriteLine("No Diff = " + Math.Abs(sum - sum1));
            }
        }
    }
}
