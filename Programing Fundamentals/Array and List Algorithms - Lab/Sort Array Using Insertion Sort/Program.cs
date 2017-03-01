using System;
using System.Collections.Generic;
using System.Linq;

class Sort_Array_Using_Insertion_Sort
{
    static void Main()
    {
        var numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int i = 0; i < numbersList.Count - 1; i++)
        {
            var current = i + 1;

            while (current > 0)
            {
                if (numbersList[current] < numbersList[current - 1])
                {
                    var temp = numbersList[current];
                    numbersList[current] = numbersList[current - 1];
                    numbersList[current - 1] = temp;
                }
                current--;
            }
        }
        Console.WriteLine(string.Join(" ", numbersList));
    }
}
