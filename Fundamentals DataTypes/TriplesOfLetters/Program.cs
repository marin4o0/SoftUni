using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int num = 0; num < n; num++)
                for (int num1 = 0; num1 < n; num1++)
                    for (int num2 = 0; num2 < n; num2++)
                    {
                        char letter = (char)('a' + num);
                        char letter1 = (char)('a' + num1);
                        char letter2 = (char)('a' + num2);
                        Console.WriteLine("{0}{1}{2}", letter, letter1, letter2);
                    }
        }
    }
}
