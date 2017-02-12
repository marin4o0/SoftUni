
using System;

public class Largest_Element_in_Array
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        var arrNumbers = new int[number];

        var largest = int.MinValue;
        
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            var numbers = int.Parse(Console.ReadLine());
            arrNumbers[i] = numbers;
            if (arrNumbers[i]>largest)
            {
                largest = arrNumbers[i];
            }
        }
        Console.WriteLine(largest);
    }
}

