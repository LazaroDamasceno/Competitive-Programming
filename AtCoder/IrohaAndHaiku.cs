using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split();
            int A = int.Parse(token[0]); 
            int B = int.Parse(token[1]);
            int C = int.Parse(token[2]);
            Console.WriteLine(IrohaAndHaiku(A, B, C));
        }

        static string IrohaAndHaiku(int A, int B, int C)
        {
            return (A+B+C) <= 17 ? "YES" : "NO";
        }
    }
}
