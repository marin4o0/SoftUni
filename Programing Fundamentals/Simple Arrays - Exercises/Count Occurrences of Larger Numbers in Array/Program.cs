using System;
using System.Linq;

public class Count_Occurrences_of_Larger_Numbers_in_Array
{
    public static void Main()
    {
        var array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var numberForEquals = double.Parse(Console.ReadLine());

        var biggerThanCounter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > numberForEquals)
            {
                biggerThanCounter++;
            }
        }
        Console.WriteLine(biggerThanCounter);
    }
}