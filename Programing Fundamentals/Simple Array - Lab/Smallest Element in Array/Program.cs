using System;

class Smallest_Element_in_Array
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();

        var arr = new int[input.Length];

        var minValue = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(input[i]);

            if (arr[i] < minValue)
            {
                minValue = arr[i];
            }
        }
        Console.WriteLine(minValue);
    }
}