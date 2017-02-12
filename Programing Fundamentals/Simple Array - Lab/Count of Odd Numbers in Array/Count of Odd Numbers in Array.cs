using System;
using System.Linq;

class Count_of_Odd_Numbers_in_Array

{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var count = 0;
        var arrnumber = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            arrnumber = numbers[i];

            if (arrnumber % 2 != 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
