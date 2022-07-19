using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 0) break;
                Console.WriteLine($"Case {counter++}: {input}");
            }
        }
    }
}
