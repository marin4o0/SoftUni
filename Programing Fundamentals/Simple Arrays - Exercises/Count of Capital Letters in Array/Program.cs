using System;
using System.Linq;

public class Count_of_Capital_Letters_in_Array
{
    public static void Main()
    {
        var array = Console.ReadLine().Split(' ').ToArray();

        var count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length == 1)
            {
                if (Char.IsUpper(array[i][0]))
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}