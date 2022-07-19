using System;
using System.Linq;
using System.Collections.Generic;

namespace Beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            int inNum = 0;
            int outNum = 0;
            int testcases = int.Parse(Console.ReadLine());
            while (testcases != 0)
            {
                int input = int.Parse(Console.ReadLine());
                if (input >- 10 && input <= 20) { inNum++; }
                else { outNum++; }
                testcases--;
            }
            Console.WriteLine($"{inNum} in\n{outNum} out");
        }
    }
}
