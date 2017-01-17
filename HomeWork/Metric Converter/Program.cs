using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();
            var mm = 1000;
            var cm = 100;
            var mi = 0.000621371192;
            var inch = 39.3700787;
            var km = 0.001;
            var ft = 3.2808399;
            var yd = 1.0936133;
            if (input == "mm")
            {
                num /= mm;
            }
            else if (input == "cm")
            {
                num /= cm;
            }
            else if (input == "mi")
            {
                num /= mi;
            }
            else if (input == "in")
            {
                num /= inch;
            }
            else if (input == "km")
            {
                num /= km;
            }
            else if (input == "ft")
            {
                num /= ft;
            }
            else if (input == "yd")
            {
                num /= yd;
            }

            if (output == "mm")
            {
                num *= mm;
            }
            else if (output == "cm")
            {
                num *= cm;
            }
            else if (output == "mi")
            {
                num *= mi;
            }
            else if (output == "in")
            {
                num *= inch;
            }
            else if (output == "km")
            {
                num *= km;
            }
            else if (output == "ft")
            {
                num *= ft;
            }
            else if (output == "yd")
            {
                num *= yd;
            }
            Console.WriteLine(num);
        }
    }
}
