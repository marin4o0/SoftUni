using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = BigInteger.Parse(Console.ReadLine());

            if (input >= -9223372036854775808 && input <= 9223372036854775807)
            {
                Console.WriteLine("{0} can fit in:", input);

                if (input >= -128 && input <= 127)
                {
                    Console.WriteLine("* sbyte");
                }
                if (input >= 0 && input <= 255)
                {
                    Console.WriteLine("* byte");
                }
                if (input >= -32768 && input <= 32767)
                {
                    Console.WriteLine("* short");
                }
                if (input >= 0 && input <= 65535)
                {
                    Console.WriteLine("* ushort");
                }
                if (input >= -2147483648 && input <= 2147483647)
                {
                    Console.WriteLine("* int");
                }
                if (input >= 0 && input <= 4294967295)
                {
                    Console.WriteLine("* uint");
                }
                if (input >= -9223372036854775808 && input <= 9223372036854775807)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
        }
    }
}
