using System;
using System.Collections.Generic;
using System.Linq;

class Average_Char_Delime
{
    static void Main()
    {
        var inputList = Console.ReadLine().Split(' ').ToList();
        double sumOfChars = 0;
        int numbersOfChars = 0;

        for (int i = 0; i < inputList.Count; i++)
        {
            numbersOfChars += inputList[i].Count();
            double sumOfElement = 0;
            foreach (var element in inputList[i])
            {
                sumOfElement += (double)element;
            }
            sumOfChars += sumOfElement;

            if (sumOfElement < numbersOfChars)
            {
                var temp = inputList[i];
                inputList[i] = inputList[i + 1];
                inputList[i + 1] = temp;
            }
        }
    }
}