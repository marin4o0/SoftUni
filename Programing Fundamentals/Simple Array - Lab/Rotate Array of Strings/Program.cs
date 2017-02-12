using System;
using System.Linq;

class Rotate_Array_of_Strings
{
    static void Main(string[] args)
    {
        var array = Console.ReadLine().Split().ToArray();

        var rotatedArray = new string[array.Length];

        for (int i = 0; i < array.Length - 1; i++)
        {
            rotatedArray[i + 1] = array[i];
        }
        var lastElement = array[rotatedArray.Length - 1];

        rotatedArray[0] = lastElement;

        Console.WriteLine(string.Join(" ", rotatedArray));
    }

}