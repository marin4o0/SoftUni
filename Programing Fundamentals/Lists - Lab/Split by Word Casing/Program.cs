using System;
using System.Collections.Generic;
using System.Linq;

public class Split_by_Word_Casing
{
    public static void Main()
    {
        var separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
        var textList = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

        var lowerCaseList = new List<string>();
        var mixedCaseList = new List<string>();
        var upperCaseList = new List<string>();

        foreach (var word in textList)
        {
            var wordType = GetWordType(word);

            if (wordType == WordType.LowerCase)
            {
                lowerCaseList.Add(word);
            }

            else if (wordType == WordType.UpperCase)
            {
                upperCaseList.Add(word);
            }

            else
            {
                mixedCaseList.Add(word);
            }
        }
        Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseList));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseList));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseList));

    }

    enum WordType { UpperCase, MixedCase, LowerCase };

    static WordType GetWordType(string word)
    {
        var lowerLetters = 0;
        var upperLetters = 0;

        foreach (var letter in word)
        {
            if (char.IsUpper(letter))
            {
                upperLetters++;
            }

            else if (char.IsLower(letter))
            {
                lowerLetters++;
            }
        }

        if (upperLetters == word.Length)
        {
            return WordType.UpperCase;
        }

        if (lowerLetters==word.Length)
        {
            return WordType.LowerCase;
        }

        else
        {
            return WordType.MixedCase;
        }
    }
}
