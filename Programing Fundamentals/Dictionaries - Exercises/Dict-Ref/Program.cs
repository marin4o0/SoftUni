using System;
using System.Collections.Generic;
using System.Linq;

namespace Dict_Ref
{
    public class Dictionaries
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var nameValue = new Dictionary<string, int>();

            while (input != "end")
            {
                var splited = input.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                var name = splited[0];
                var value = int.Parse(splited[1]);

                nameValue[name] = value;

                input = Console.ReadLine();
            }
            foreach (var item in nameValue)
            {
                Console.WriteLine("{0}=== {1}", item.Key, item.Value);
            }
        }
    }
}