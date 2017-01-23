using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            if (figure == "square")
            {
                var num = double.Parse(Console.ReadLine());
                num *= num;
                Console.WriteLine(Math.Round(num, 3));
            }
            else if (figure == "rectangle")
            {
                var num = double.Parse(Console.ReadLine());
                var num1 = double.Parse(Console.ReadLine());
                num *= num1;
                Console.WriteLine(Math.Round(num, 3));
            }
            else if (figure == "circle")
            {
                var num = double.Parse(Console.ReadLine());
                num = Math.PI * (num * num);
                Console.WriteLine(Math.Round(num, 3));
            }
            else if (figure == "triangle")
            {
                var num = double.Parse(Console.ReadLine());
                var num1 = double.Parse(Console.ReadLine());
                num = num * num1 / 2;
                Console.WriteLine(Math.Round(num, 3));
            }

        }
    }
}
