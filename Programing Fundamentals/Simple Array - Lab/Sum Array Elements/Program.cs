using System;

namespace Sum_Array_Elements
{
    class Program
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var arr = new int[number];

            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
