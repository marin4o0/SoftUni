using System;
using System.Collections.Generic;
using System.Linq;

class Array_Contains_Element
{
    static void Main()
    {
        var numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var n = int.Parse(Console.ReadLine());

        bool isEqual = false;

        for (int i = 0; i < numbersList.Count; i++)
        {
            if (n==numbersList[i])
            {
                isEqual = true;
            }
        }

        if (isEqual)
        {
            Console.WriteLine("yes");
        }

        else
        {
            Console.WriteLine("no");
        }
    }
}
