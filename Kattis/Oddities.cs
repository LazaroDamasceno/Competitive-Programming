using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] token;
            // token = Console.ReadLine().Split();
            int testcases = int.Parse(Console.ReadLine());
            while (testcases > 0)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number % 2 == 0 ? $"{number} is even" : $"{number} is odd");
                testcases--;
            }
        }
    }
}
