using System;
using System.Linq;

public class Array_Elements_Equal_to_Their_Index
{
    public static void Main()
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == i)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
