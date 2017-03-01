using System;
using System.Collections.Generic;
using System.Linq;

class Sort_Array_Using_Bubble_Sort
{
    static void Main()
    {
        var numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        bool swaped = false;

        do
        {
            swaped = false;

            for (int i = 0; i < numbersList.Count - 1; i++)
            {
                var current = numbersList[i];
                var next = numbersList[i + 1];

                if (current > next)
                {
                    numbersList[i + 1] = current;
                    numbersList[i] = next;
                    swaped = true;
                }
            }

        } while (swaped);

        Console.WriteLine(string.Join(" ", numbersList));
    }
}
