using System;
using System.Linq;

public class Equal_Sequence_of_Elements_in_Array
{
    public static void Main()
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var savedNumber = array[0];

        bool isEqual = true;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == savedNumber)
            {
                savedNumber = array[i];
                isEqual = true;
            }

            else
            {
                isEqual = false;
                break;
            }
        }

        if (isEqual == true)
        {
            Console.WriteLine("Yes");
        }

        else
        {
            Console.WriteLine("No");
        }
    }
}