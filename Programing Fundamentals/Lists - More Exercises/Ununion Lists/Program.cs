using System;
using System.Collections.Generic;
using System.Linq;

class Ununion_Lists
{
    static void Main()
    {
        var numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var newList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int index = 0; index < newList.Count; index++)
            {
                if (numbersList.Contains(newList[index]))
                {
                    numbersList.RemoveAll(x => x == newList[index]);
                }
                else
                {
                    numbersList.Add(newList[index]);
                }
            }
        }
        numbersList.Sort();
        Console.WriteLine(string.Join(" ", numbersList));
    }
}
