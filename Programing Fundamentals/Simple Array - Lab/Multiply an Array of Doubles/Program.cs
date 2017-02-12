using System;

class Multiply_an_Array_of_Doubles
{
    static void Main(string[] args)
    {
        var stringArr = Console.ReadLine().Split();
        var multiply = double.Parse(Console.ReadLine());
        var arr = new double[stringArr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = double.Parse(stringArr[i]);
            arr[i] *= multiply;
            Console.Write(arr[i] + " ");
        }
    }
}

