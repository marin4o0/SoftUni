using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            while(num2 > 0)
            {
                var temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            Console.WriteLine(num1);
        }
    }
}
