using System;
using System.Collections.Generic;
using System.Linq;

namespace Letter_Repetition
{
    public class Dictionaries
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower().ToCharArray();

            var chars = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (!chars.ContainsKey(character))
                {
                    chars[character] = 0;
                }

                chars[character]++;
            }
            foreach (var item in chars)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
