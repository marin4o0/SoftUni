using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            if (word == "banana" || word == "apple" || word == "kiwi" || word == "cherry" || word == "lemon"|| word == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (word == "tomato" || word == "cucumber" || word == "pepper" || word == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
