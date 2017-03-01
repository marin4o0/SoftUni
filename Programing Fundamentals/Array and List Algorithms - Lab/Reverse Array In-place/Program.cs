using System;
using System.Collections.Generic;
using System.Linq;

class Reverse_Array_In_place
{
    static void Main()
    {
        var numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        numbersList.Reverse();

        Console.WriteLine(string.Join(" ", numbersList));
    }
}
