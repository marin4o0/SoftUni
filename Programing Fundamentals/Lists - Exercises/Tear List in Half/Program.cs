using System;
using System.Collections.Generic;
using System.Linq;

public class Tear_List_in_Half
{
    public static void Main()
    {
        var numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var leftSide = new List<int>();
        var rightSide = new List<int>();
        var result = new List<int>();

        for (int i = 0; i < numbersList.Count / 2; i++)
        {
            leftSide.Add(numbersList[i]);
        }

        for (int i = numbersList.Count/2; i < numbersList.Count; i++)
        {
            rightSide.Add(numbersList[i]);
        }

        for (int i = 0; i < leftSide.Count; i++)
        {
            result.Add(rightSide[i] / 10);
            result.Add(leftSide[i]);
            result.Add(rightSide[i] % 10);
        }
        Console.WriteLine(string.Join(" ", result));
    }
}