using System;
using System.Collections.Generic;
using System.Linq;

public class Append_Lists
{
    public static void Main()
    {
        var numberList = Console.ReadLine()
            .Split('|')
            .ToList();

        numberList.Reverse();

        var result = new List<string>();

        foreach (var item in numberList)
        {
            var numbers = item.Split(' ').ToList();

            foreach (var number in numbers)
            {
                if (number != "")
                {
                    result.Add(number);
                }
            }
        }
        Console.WriteLine(string.Join(" ", result));
    }
}