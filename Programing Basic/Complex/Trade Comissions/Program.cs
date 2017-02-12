using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var sale = double.Parse(Console.ReadLine());
            double comision = -1;
            if (town == "sofia")
            {
                if (0 <= sale && sale <= 500)
                {
                    comision = sale * 0.05;
                }
                else if (500 < sale && sale <= 1000)
                {
                    comision = sale * 0.07;
                }
                else if (1000 < sale && sale <= 10000)
                {
                    comision = sale * 0.08;
                }
                else if (sale > 10000)
                {
                    comision = sale * 0.12;
                }
                else if (comision < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("{0:F2}", comision);
            }
            else if (town == "varna")
            {
                if (0 <= sale && sale <= 500)
                {
                    comision = sale * 0.045;
                }
                else if (500 < sale && sale <= 1000)
                {
                    comision = sale * 0.075;
                }
                else if (1000 < sale && sale <= 10000)
                {
                    comision = sale * 0.10;
                }
                else if (sale > 10000)
                {
                    comision = sale * 0.13;
                }
                else if (comision < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("{0:F2}", comision);
            }
            else if (town == "plovdiv")
            {
                if (0 <= sale && sale <= 500)
                {
                    comision = sale * 0.055;
                }
                else if (500 < sale && sale <= 1000)
                {
                    comision = sale * 0.08;
                }
                else if (1000 < sale && sale <= 10000)
                {
                    comision = sale * 0.12;
                }
                else if (sale > 10000)
                {
                    comision = sale * 0.145;
                }
                else if (comision < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("{0:F2}", comision);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}

