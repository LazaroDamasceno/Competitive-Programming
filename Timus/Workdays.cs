using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split();
            int N = int.Parse(token[0]);
            int M = int.Parse(token[1]);
            Console.WriteLine(N * ++M);
        }
    }
}
