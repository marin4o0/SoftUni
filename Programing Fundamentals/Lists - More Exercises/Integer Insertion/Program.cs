using System;
using System.Collections.Generic;
using System.Linq;

class Integer_Insertion
{
    static void Main()
    {
        var numberList = Console.ReadLine().Split(' ').ToList();
        string newNumbers = Console.ReadLine();

        while (newNumbers != "end")
        {
            int firstDigit = (newNumbers[0] -48);

            numberList.Insert(firstDigit, newNumbers);

            newNumbers = Console.ReadLine();
        }
        Console.WriteLine(string.Join(" ", numberList));
    }
}