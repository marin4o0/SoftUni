using System;
using System.Linq;

public class Last_3_Consecutive_Equal_Strings
{
    public static void Main()
    {
        var array = Console.ReadLine().Split(' ');

        var lastThree = string.Empty;

        var count = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] == array[i])
            {
                count++;
            }

            else if (array[i + 1] != array[i])
            {
                count = 1;
            }

            if (count == 3)
            {
                lastThree = array[i];
                count = 1;
            }
        }
        Console.WriteLine("{0} {0} {0}", lastThree);
    }
}
