using System;
using System.Collections.Generic;
using System.Linq;

class Remove_Negatives_and_Reverse
{
    static void Main()
    {
        var numberList = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var result = new List<int>();
        var count = 0;

        foreach (var number in numberList)
        {
            if (number > 0)
            {
                result.Add(number);
                count++;
            }
        }

        if (count != 0)
        {
            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }

        else
        {
            Console.WriteLine("empty");
        }
    }
}