using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string[] token;
            token = Console.ReadLine().Split(); */
            int testCases = int.Parse(Console.ReadLine());
            while (testCases > 0)
            {
                int burles = int.Parse(Console.ReadLine());
                int b = (int) Math.Round(burles / 3.0);
                Console.WriteLine((burles - 2*b) + " " + b);
                testCases--;
            }
        }
    }
}
