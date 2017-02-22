using System;
using System.Linq;

public class Phonebook
{
    public static void Main(string[] args)
    {
        var arrayNumbers = Console.ReadLine().Split(' ');
        var arrayNames = Console.ReadLine().Split(' ');

        var result = string.Empty;

        for (int i = 0; ; i++)
        {
            var name = Console.ReadLine();

            if (name == "done")
            {
                break;
            }

            for (int index = 0; index < arrayNumbers.Length; index++)
            {
                if (name == arrayNames[index])
                {
                    result += $"{arrayNames[index]} -> {arrayNumbers[index]}" + Environment.NewLine;
                }
            }
        }
        Console.WriteLine(result);
    }
}