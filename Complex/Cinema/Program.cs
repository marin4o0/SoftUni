using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var cinema = Console.ReadLine().ToLower();
            var red = int.Parse(Console.ReadLine());
            var kolona = int.Parse(Console.ReadLine());
            double mesta = red * kolona;
            double total = 1;
            if (cinema == "premiere")
            {
                total = mesta * 12.00;
                Console.WriteLine("{0:F2}", total);
            }
            else if (cinema == "normal")
            {
                total = mesta * 7.50;
                Console.WriteLine("{0:F2}", total);
            }
            else if (cinema == "discount")
            {
                total = mesta * 5.00;
                Console.WriteLine("{0:F2}", total);
            }
            
        }
    }
}
