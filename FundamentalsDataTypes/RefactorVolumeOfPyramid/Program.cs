﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            var length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            var heigth = double.Parse(Console.ReadLine());
            double volume = 0;
            volume = ((length * width) * heigth) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
