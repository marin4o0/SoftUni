using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            double weekendsInYear = 48;
            double total = 0;
            double weekendsInSofia = weekendsInYear - h;
            double holidays = p;
            if (year == "leap")
            {
                double gamesinSofia = (weekendsInSofia * 3.0) / 4;
                double gamesInHolidays = (holidays * 2.0 / 3);
                total = gamesinSofia + gamesInHolidays + h;
                Console.WriteLine(Math.Truncate(total + (total * 0.15)));
            }
            else if (year == "normal")
            {
                double gamesinSofia = (weekendsInSofia * 3.0) / 4;
                double gamesInHolidays = (holidays * 2.0 / 3);
                total = gamesinSofia + gamesInHolidays + h;
                Console.WriteLine(Math.Truncate(total));
            }

        }
    }
}
