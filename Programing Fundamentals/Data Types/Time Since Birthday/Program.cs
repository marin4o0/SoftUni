using System;


namespace Time_Since_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = byte.Parse(Console.ReadLine());

            var days = year * 365;
            var hours = days * 24;
            var minutes = hours * 60;

            Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes",year, days, hours, minutes);
        }
    }
}
