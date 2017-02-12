using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstnum = int.Parse(Console.ReadLine());
            var secondnum = int.Parse(Console.ReadLine());
            var sum = firstnum + secondnum;
            var sum1 = 0;
            var maxDiff = 0;
            for (int i = 1; i < n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                sum1 = num1 + num2;
                if (sum != sum1)
                {
                    var diff = Math.Abs(sum - sum1);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
                sum = sum1;
            }
            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
