using System;
using System.Collections.Generic;
using System.Linq;

public class Square_Numbers
{
    public static void Main()
    {
        var separators = new char[] { ' ' };

        var numbers = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
        numbers.Sort();
        numbers.Reverse();

        var result = new List<string>();

        foreach (var number in numbers)
        {
            if (Math.Sqrt(number) % 1 == 0)
            {
                result.Add(Convert.ToString(number));
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}