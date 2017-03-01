using System;
using System.Collections.Generic;
using System.Linq;

class Largest_N_Elements
{
    static void Main()
    {
        var numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var n = int.Parse(Console.ReadLine());

        var result = new List<int>();

        numbersList.Sort();
        numbersList.Reverse();

        for (int i = 0; i < n; i++)
        {
            result.Add(numbersList[i]);
        }
        Console.WriteLine(string.Join(" ", result));
    }
}