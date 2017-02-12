using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexValue = Convert.ToString(Console.ReadLine());
            var decValue = Convert.ToInt32(hexValue, 16);

            Console.WriteLine(decValue);
        }
    }
}
