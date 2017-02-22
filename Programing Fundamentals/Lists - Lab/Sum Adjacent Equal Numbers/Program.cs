using System;
using System.Collections.Generic;
using System.Linq;

public class Sum_Adjacent_Equal_Numbers
{
    public static void Main()
    {
        var numbersList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

        var result = new List<string>();

        for (int i = 1; i < numbersList.Count; i++)
        {
            if (numbersList[i - 1] == numbersList[i])
            {
                numbersList[i - 1] += numbersList[i];
                numbersList.RemoveAt(i);
                i = 0;
            }
        }
        Console.WriteLine(string.Join(" ", numbersList));
    }
}