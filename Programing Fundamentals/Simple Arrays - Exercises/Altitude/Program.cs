using System;
using System.Linq;

class Altitude
{
    static void Main()
    {
        var array = Console.ReadLine().Split(' ').ToArray();

        var altitude = Convert.ToDouble(array[0]);

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == "up")
            {
                altitude += Convert.ToDouble(array[i + 1]);
            }

            else if (array[i] == "down")
            {
                altitude -= Convert.ToDouble(array[i + 1]);
            }
        }

        if (altitude > 0)
        {
            Console.WriteLine("got through safely. current altitude: {0}m", altitude);
        }

        else if (altitude <= 0)
        {
            Console.WriteLine("crashed");
        }
    }
}