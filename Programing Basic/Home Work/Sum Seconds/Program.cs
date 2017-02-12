using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var total = num1 + num2 + num3;
            var min = total / 60;
            var sec = total % 60;
            Console.WriteLine("{0}:{1:00}", min, sec);
        }
    }
}
