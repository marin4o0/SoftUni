using System;

public class Array_Symmetry
{
    public static void Main()
    {
        var array = Console.ReadLine().Split(' ');

        bool isSymmetry = true;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[0] == array[array.Length - 1] && array[1] == array[array.Length - 2] && array[2] == array[array.Length - 3])
            {
                isSymmetry = true;
            }

            else
            {
                isSymmetry = false;
            }
        }

        if (isSymmetry == true)
        {
            Console.WriteLine("Yes");
        }

        else
        {
            Console.WriteLine("No");
        }
    }
}