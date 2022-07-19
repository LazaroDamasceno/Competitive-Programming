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
            const int maxMin = 24 * 60;
            int givenTime = 0;
            int testcases = int.Parse(Console.ReadLine());
            while (testcases > 0)
            {
                token = Console.ReadLine().Split(' ');
                int hours = int.Parse(token[0]);
                int minutes = int.Parse(token[1]);
                givenTime += hours * 60;
                givenTime += minutes;
                Console.WriteLine(maxMin - givenTime);
                givenTime = 0;
                testcases--;
            }
        }
    }
}
