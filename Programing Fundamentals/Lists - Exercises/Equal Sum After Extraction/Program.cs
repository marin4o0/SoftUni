using System;
using System.Collections.Generic;
using System.Linq;

public class Equal_Sum_After_Extraction
{
    public static void Main()
    {
        var numbersLineOne = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var numbersLineTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        numbersLineOne.Sort();
        numbersLineTwo.Sort();

        for (int i = 0; i < numbersLineOne.Count; i++)
        {
            for (int j = 0; j < numbersLineTwo.Count; j++)
            {
                if (numbersLineTwo[j] == numbersLineOne[i])
                {
                    numbersLineTwo.Remove(numbersLineTwo[j]);
                }
            }
        }

        var difference = Math.Abs(numbersLineOne.Sum() - numbersLineTwo.Sum());

        if (numbersLineOne.Sum() == numbersLineTwo.Sum())
        {
            Console.WriteLine("Yes. Sum: {0}", numbersLineOne.Sum());
        }

        else
        {
            Console.WriteLine("No. Diff: {0}", difference);
        }
    }
}
