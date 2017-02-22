using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToList();
            numbers.Sort();
            
            var counter = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1 || numbers[i] != numbers[i + 1])
                {
                    Console.WriteLine("{0} -> {1}", numbers[i], counter);
                    counter = 1;
                }

                else
                {
                    counter++;
                }
            }
        }
    }
}
