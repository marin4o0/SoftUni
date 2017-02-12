using System;

class PriceChangeAlert
{
    static void Main()
    {
        var priceNuber = int.Parse(Console.ReadLine());
        var percentDifference = double.Parse(Console.ReadLine());
        var lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < priceNuber - 1; i++)
        {
            var nuberCount = double.Parse(Console.ReadLine());
            double difference = DifferenceInPercent(lastPrice, nuberCount);
            bool isSignificantDifference = isDifferent(difference, percentDifference);
            string message = Get(nuberCount, lastPrice, difference, isSignificantDifference);

            Console.WriteLine(message);

            lastPrice = nuberCount;
        }
    }

    private static string Get(double nuberCount, double lastPrice, double difference, bool etherTrueOrFalse)
    {
        string to = "";
        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", nuberCount);
        }

        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2}%)", lastPrice, nuberCount, difference);
        }

        else if (etherTrueOrFalse && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2}%)", lastPrice, nuberCount, difference);
        }

        else if (etherTrueOrFalse && (difference < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2}%)", lastPrice, nuberCount, difference);

        return to;
    }

    private static bool isDifferent(double percentDifference, double isDifferent)
    {
        if (Math.Abs(percentDifference) >= isDifferent)
        {
            return true;
        }

        return false;
    }

    private static double DifferenceInPercent(double lastPrice, double nuberCount)
    {
        double DifferenceInPercent = ((nuberCount - lastPrice) / lastPrice) * 100;
        return DifferenceInPercent;
    }
}
