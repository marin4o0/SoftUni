using System;
using System.Collections.Generic;
using System.Linq;

public class Flip_List_Sides
{
    public static void Main()
    {
        var listOne = Console.ReadLine().Split(' ').ToList();
        listOne.Reverse();

        var first = listOne[0];
        var last = listOne[listOne.Count - 1];

        listOne[0] = last;
        listOne[listOne.Count - 1] = first;

        Console.WriteLine(string.Join(" ", listOne));
    }
}