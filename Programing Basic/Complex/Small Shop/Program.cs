using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var city = Console.ReadLine();
            var number = double.Parse(Console.ReadLine());
            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(number * 0.50);
                }
                else if (product == "water")
                {
                    Console.WriteLine(number * 0.80);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(number * 1.20);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(number * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(number * 1.60);
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(number * 0.40);
                }
                else if (product == "water")
                {
                    Console.WriteLine(number * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(number * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(number * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(number * 1.50);
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(number * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(number * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(number * 1.10);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(number * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(number * 1.55);
                }
            }
        }
    }
}
