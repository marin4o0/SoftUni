using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            RaiseToPower(number, power);
        }

        private static void RaiseToPower(double number, int power)
        {
            double result = Math.Pow(number, power);

            Console.WriteLine(result);
        }
    }
}
