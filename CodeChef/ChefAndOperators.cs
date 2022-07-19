using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token;
            // token = Console.ReadLine().Split(' ');
            int testcases = int.Parse(Console.ReadLine());
            while (testcases != 0)
            {
                token = Console.ReadLine().Split(' ');
                int a = int.Parse(token[0]);
                int b = int.Parse(token[1]);
                Console.WriteLine(a > b ? ">" : a < b ? "<" : "=");
                testcases--;
            }
        }
    }
}
