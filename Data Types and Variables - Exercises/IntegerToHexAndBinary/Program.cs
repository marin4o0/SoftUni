using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var hex = input.ToString("X");

            string binary = Convert.ToString(input, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
