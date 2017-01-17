using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number1 = 0;
            var number2 = 0;
            for (int i = 1; i <= n; i++)
            {
                var numberLeft = int.Parse(Console.ReadLine());
                number1 += numberLeft;
            }
            for (int i = 1; i <= n; i++)
            {
                var numberRight = int.Parse(Console.ReadLine());
                number2 += numberRight;
            }
            if (number1 == number2)
            {
                Console.WriteLine("Yes, sum = " + number1);
            }
            else if (number1 != number2)
            {
                Console.Write("No, diff = ");
                Console.WriteLine(Math.Abs(number1 - number2));
            }
        }
    }
}
