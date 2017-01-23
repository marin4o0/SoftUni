using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var num1 = double.Parse(Console.ReadLine());
            var min = (num1 + 15);
            if (min >= 60)
            {
                min -= 60;
                num++;
            }

            if (num >= 24)
            {
                num -= 24;
            }
            Console.WriteLine("{0}:{1:00}", num, min);
        }
    }
}
