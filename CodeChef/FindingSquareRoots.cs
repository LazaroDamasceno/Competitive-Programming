using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            while (testcases != 0)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine((int)Math.Sqrt(number));
                testcases--;
            }
        }
    }
}
