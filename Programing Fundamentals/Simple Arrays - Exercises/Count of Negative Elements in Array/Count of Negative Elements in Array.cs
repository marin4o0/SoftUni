
using System;

class Count_of_Negative_Elements_in_Array
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        var arrNumbers = new int[number];

        var countNegative = 0;

        for (int i = 0; i < arrNumbers.Length; i++)
        {
            var numbers = int.Parse(Console.ReadLine());

            arrNumbers[i] = numbers;

            if (arrNumbers[i] < 0)
            {
                countNegative++;
            }
        }
        Console.WriteLine(countNegative);
    }
}