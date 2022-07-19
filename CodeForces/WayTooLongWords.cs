using System;
using System.Collections.Generic;
using System.Linq;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] token;
            // token = Console.ReadLine().Split(' ');
            int testcases = int.Parse(Console.ReadLine());
            while (testcases != 0)
            {
                string word = Console.ReadLine();
                Console.WriteLine(word.Length <= 10 ? word : BiggerThan10(word));
                testcases--;
            }
        }

        static string BiggerThan10(string word)
        {
            char firstLetter = word.ElementAt(0);
            char lastLetter = word.ElementAt(word.Length - 1);
            string finalWord = string.Concat(firstLetter, word.Length - 2, lastLetter);
            return  finalWord;
        }
    }
}

// https://codeforces.com/problemset/problem/71/A
