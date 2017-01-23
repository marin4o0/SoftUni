using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int isPrime = 2; isPrime <= number; isPrime++)
            {
                bool prime = true;
                for (int dividing = 2; dividing <= Math.Sqrt(isPrime); dividing++)
                {
                    if (isPrime % dividing == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{isPrime} -> {prime}");
            }
        }
    }
}
