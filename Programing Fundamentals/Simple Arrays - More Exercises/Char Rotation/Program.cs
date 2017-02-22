using System;
using System.Linq;

public class Char_Rotation
{
    public static void Main()
    {
        var input = Console.ReadLine().ToCharArray();
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var resulst = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                resulst += Convert.ToChar(input[i] - numbers[i]);
            }

            else if (numbers[i] % 2 != 0)
            {
                resulst += Convert.ToChar(input[i] + numbers[i]);
            }
        }
        Console.WriteLine(resulst);
    }
}
