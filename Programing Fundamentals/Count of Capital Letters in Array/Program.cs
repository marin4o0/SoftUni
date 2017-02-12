using System;
using System.Linq;

public class Count_of_Capital_Letters_in_Array
{
    public static void Main()
    {
        var array = Console.ReadLine().ToString().ToArray();

        var count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (Char.IsUpper(array[i]))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}