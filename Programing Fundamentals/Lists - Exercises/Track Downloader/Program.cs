
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace simpleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blackList = Console.ReadLine().Split();
            string forDownload = Console.ReadLine();

            List<string> list = new List<string>();

            while (forDownload != "end")
            {
                bool isThere = false;
                for (int i = 0; i < blackList.Length; i++)
                {
                    if (forDownload.Contains(blackList[i]))
                    {
                        isThere = true;
                    }
                }

                if (isThere != true)
                {
                    list.Add(forDownload);
                }
                forDownload = Console.ReadLine();
            }

            foreach (var a in list.OrderBy(x => x))
            {
                Console.WriteLine(a);
            }
        }
    }
}