using System;
using System.Collections.Generic;

namespace Problem236A
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<char> myset = new HashSet<char>();
            string name = Console.ReadLine();
            foreach (char el in name)
                myset.Add(el);
            if (myset.Count % 2 == 0)
                Console.WriteLine("CHAT WITH HER!");
            else
                Console.WriteLine("IGNORE HIM!");
        }
    }
}
