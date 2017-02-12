using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var number = int.Parse(Console.ReadLine());
                    if (number % 2 != 0)
                    {
                        Console.WriteLine("The number is not even.");
                    }
                    else
                    {
                        Console.WriteLine("Even number entered: {0}", number);
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
