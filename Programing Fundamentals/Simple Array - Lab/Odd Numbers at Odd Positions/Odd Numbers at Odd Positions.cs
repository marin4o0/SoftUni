using System;
using System.Linq;

namespace Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            var oddNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                oddNumber = numbers[i];

                if (oddNumber % 2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine("Index {0} -> {1}", i, oddNumber);
                }
            }
        }
    }
}
