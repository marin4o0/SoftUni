using System;
using System.Collections.Generic;
using System.Linq;

class Sort_Array_of_Strings
{
    static void Main()
    {
        var inputList = Console.ReadLine().Split(' ').ToList();

        double sumOfChars = 0;
        var count = 1; ;

        while (count == 1)
        {
            count = 0;
            for (int i = 0; i < inputList.Count; i++)
            {

                double sumOfElement = 0;
                foreach (var element in inputList[i])
                {
                    sumOfElement += (double)element;
                }

                if (sumOfElement < sumOfChars && i > 0)
                {
                    var temp = inputList[i - 1];
                    inputList[i - 1] = inputList[i];
                    inputList[i] = temp;
                    count = 1;
                }
                sumOfChars = sumOfElement;
            }
        }
        Console.WriteLine(string.Join(" ", inputList));
    }
}
