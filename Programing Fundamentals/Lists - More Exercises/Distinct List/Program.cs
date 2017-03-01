using System;
using System.Collections.Generic;
using System.Linq;

class Distinct_List
{
    static void Main()
    {
        var numberList = Console.ReadLine().Split(' ').ToList();
        var noDupes = numberList.Distinct().ToList();
        
        Console.WriteLine(string.Join(" ", noDupes));
    }
}