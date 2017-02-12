using System;
using System.Linq;

public class Increasing_Sequence_of_Elements
{
    public static void Main()
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var increase = 0;

        bool isIncrease = true;

        for (int i = 0; i < array.Length; i++)
        {

            if (increase < array[i])
            {
                increase = array[i];
            }

            else
            {
                isIncrease = false;
                break;
            }

            isIncrease = true;
        }

        if (isIncrease == true)
        {
            Console.WriteLine("Yes");
        }

        else
        {
            Console.WriteLine("No");
        }
    }
}
