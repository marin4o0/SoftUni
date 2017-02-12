using System;
using System.Linq;

class Count_of_Given_Element_in_Array
{
    static void Main()
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var given = int.Parse(Console.ReadLine());

        var givenCounter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == given)
            {
                givenCounter++;
            }
        }
        Console.WriteLine(givenCounter);
    }
}