using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var one = char.Parse(Console.ReadLine());
            var two = char.Parse(Console.ReadLine());
            var three = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}", three, two, one);
        }
    }
}
