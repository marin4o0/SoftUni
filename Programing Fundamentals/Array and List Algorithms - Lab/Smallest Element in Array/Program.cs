using System;
using System.Collections.Generic;
using System.Linq;

class Smallest_Element_in_Array
{
    static void Main()
    {
        var numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var smallest = int.MaxValue;

        for (int i = 0; i < numbersList.Count; i++)
        {
            if (numbersList[i] < smallest)
            {
                smallest = numbersList[i];
            }
        }
        Console.WriteLine(smallest);
    }
}
