using System;
using System.Linq;

public class Increasing_Sequence_of_Elements
{
    public static void Main()
    {
        var array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var increase1 = 0;
        var increase2 = 0;

        bool isIncrease1 = true;
        bool isIncrease2 = true;

        for (int i = 0; i < array1.Length; i++)
        {

            if (increase1 < array1[i])
            {
                increase1 = array1[i];
            }

            else
            {
                isIncrease1 = false;
                break;
            }

            isIncrease1 = true;
        }


        for (int i = 0; i < array2.Length; i++)
        {
            if (increase2 < array2[i])
            {
                increase2 = array2[i];
            }

            else
            {
                isIncrease2 = false;
                break;
            }

            isIncrease2 = true;
        }

        if (isIncrease1 == true)
        {
            Console.WriteLine("Yes");
        }

        else if (isIncrease1 == false)
        {
            Console.WriteLine("No");
        }


        if (isIncrease2 == true)
        {
            Console.WriteLine("Yes");
        }

        else if (isIncrease2 == false)
        {
            Console.WriteLine("No");
        }
    }
}
