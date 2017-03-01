using System;
using System.Collections.Generic;
using System.Linq;

class Camel_s_Back
{
    static void Main()
    {
        var numbersList = Console.ReadLine().Split(' ').ToList();
        var size = int.Parse(Console.ReadLine());

        if (size == numbersList.Count)
        {
            Console.Write("already stable: ");
            Console.WriteLine(string.Join(" ", numbersList));
        }

        else
        {
            var loopNumber = (numbersList.Count - size) / 2;

            for (int i = 0; i < loopNumber; i++)
            {
                numbersList.Remove(numbersList[0]);
                numbersList.Remove(numbersList[numbersList.Count - 1]);
            }

            Console.WriteLine("{0} rounds", loopNumber);
            Console.Write("remaining: ");
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}