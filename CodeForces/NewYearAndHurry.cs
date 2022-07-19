using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeForcesInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int numberProblems = int.Parse(line[0]);
            int timeNeeded = int.Parse(line[1]);
            int counter = 0;
            for (int n =  1; n <= numberProblems; n++)
            {
                if (timeNeeded + n * 5 <= 240)
                {
                    timeNeeded += n * 5;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

// https://codeforces.com/problemset/problem/750/A
