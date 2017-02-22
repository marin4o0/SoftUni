using System;
using System.Collections.Generic;
using System.Linq;

public class Remove_Elements_at_Odd_Positions
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(' ').ToList();

        var result = string.Empty;

        for (int i = 0; i < input.Count; i++)
        {
            if (i % 2 != 0)
            {
                result += input[i];
            }
        }
        Console.WriteLine(result);
    }
}