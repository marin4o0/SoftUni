using System;
using System.Linq;

class TrickyStrings
{
    static void Main(string[] args)
    {
        var delimiter = Console.ReadLine();
        var numberOfStrings = int.Parse(Console.ReadLine());

        var text = new string[numberOfStrings];

        for (int i = 0; i < numberOfStrings; i++)
        {
            text[i] = Console.ReadLine();
        }

        Console.WriteLine(string.Join(delimiter, text));
    }
}