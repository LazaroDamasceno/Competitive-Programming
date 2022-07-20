using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] token = Console.ReadLine().Split();
            string input = Console.ReadLine();
            List<string> words = input.Split(' ').ToList();
            string output = string.Empty;
            for (int i = 0; i < words.Count; i++)
            {
                output += words.ElementAt(i).ElementAt(0);
            }
            Console.WriteLine(output);
        }
    }
}
