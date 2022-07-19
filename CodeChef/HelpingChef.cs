using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            while (testcases != 0)
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(input < 10 ? "Thanks for helping Chef!" : "-1");
                testcases--;
            }
        }
    }
}
