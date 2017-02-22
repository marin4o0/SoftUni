using System;
using System.Linq;

class Phonebook
{
    static void Main(string[] args)
    {
        var number = Console.ReadLine().Split().ToArray();
        var names = Console.ReadLine().Split().ToArray();

        string[] Wanted = new string[1];

        while (Wanted[0] != "done")
        {
            Wanted = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < number.Length; i++)
            {
                if (Wanted[0] == "call")
                {

                    if (Wanted[1] == names[i])
                    {
                        Console.WriteLine($"calling {number[i]}...");

                        CheckNumber(number[i]);
                    }

                    else if (Wanted[1] == number[i])
                    {
                        Console.WriteLine($"calling {names[i]}...");

                        CheckNumber(number[i]);
                    }
                }

                else if (Wanted[0] == "message")
                {
                    if (Wanted[1] == names[i])
                    {
                        Console.WriteLine($"sending sms to {number[i]}...");

                        CheckNumberForSMS(number[i]);
                    }

                    else if (Wanted[1] == number[i])
                    {
                        Console.WriteLine($"sending sms to {names[i]}...");

                        CheckNumberForSMS(number[i]);
                    }
                }
            }
        }
    }

    private static void CheckNumberForSMS(string v)
    {
        string phone = new string(v.Where(c => Char.IsDigit(c)).ToArray());
        long DIGITS = long.Parse(phone);
        long sumOfDigit = 0;

        while (DIGITS > 0)
        {
            sumOfDigit += DIGITS % 10;
            DIGITS /= 10;
        }

        if (sumOfDigit % 2 == 0)
        {
            long minutes = sumOfDigit / 60;
            long seconds = sumOfDigit % 60;

            Console.WriteLine("meet me there");
        }

        else
        {
            Console.WriteLine("busy");
        }
    }

    private static void CheckNumber(string v)
    {
        string phone = new string(v.Where(c => Char.IsDigit(c)).ToArray());
        long DIGITS = long.Parse(phone);
        long sumOfDigit = 0;

        while (DIGITS > 0)
        {
            sumOfDigit += DIGITS % 10;
            DIGITS /= 10;
        }

        if (sumOfDigit % 2 == 0)
        {
            long minutes = sumOfDigit / 60;
            long seconds = sumOfDigit % 60;

            Console.WriteLine("call ended. duration: {0:00}:{1:00}", minutes, seconds);
        }

        else
        {
            Console.WriteLine("no answer");
        }
    }
}