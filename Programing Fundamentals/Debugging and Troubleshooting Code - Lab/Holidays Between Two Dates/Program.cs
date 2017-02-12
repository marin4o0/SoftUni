using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        HoliDayCounter();
    }

    private static void HoliDayCounter()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
           "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);

        var holiDaysCount = 0;

        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holiDaysCount++;
            }
        }
        Console.WriteLine(holiDaysCount);
    }
}