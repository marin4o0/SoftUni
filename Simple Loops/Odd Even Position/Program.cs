using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var OddSum = 0.0;
            var OddMin = 2147483647.0;
            var OddMax = -2147483648.0;
            var EvenSum = 0.0;
            var EvenMin = 2147483647.0;
            var EvenMax = -2147483648.0;
            for (int i = 0; i < n; i++)
            {
                var numbers = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    OddSum += numbers;
                    if (numbers < OddMin)
                    {
                        OddMin = numbers;
                    }
                    if (numbers > OddMax)
                    {
                        OddMax = numbers;
                    }
                }
                if (!(i % 2 == 0))
                {
                    EvenSum += numbers;
                    if (numbers < EvenMin)
                    {
                        EvenMin = numbers;
                    }
                    if (numbers > EvenMax)
                    {
                        EvenMax = numbers;
                    }
                }
            }
            Console.WriteLine("OddSum = " + OddSum);
            if (OddMin < 2147483647.0)
            {
                Console.WriteLine("OddMin = " + OddMin);
            }
            else if (OddMin == 2147483647.0)
            {
                Console.WriteLine("OddMin = No");
            }
            if (OddMax > -2147483648.0)
            {
                Console.WriteLine("OddMax = " + OddMax);
            }
            else if (OddMax == -2147483648.0)
            {
                Console.WriteLine("OddMax = No");
            }

            Console.WriteLine("EvenSum = " + EvenSum);
            if (EvenMin < 2147483647.0)
            {
                Console.WriteLine("EvenMin = " + EvenMin);
            }
            else if (EvenMin == 2147483647.0)
            {
                Console.WriteLine("EvenMin = No");
            }
            if (EvenMax > -2147483648.0)
            {
                Console.WriteLine("EvenMax = " + EvenMax);
            }
            else if (EvenMax == -2147483648.0)
            {
                Console.WriteLine("EvenMax = No");
            }

        }
    }
}
