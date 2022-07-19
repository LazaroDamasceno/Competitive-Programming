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
            token = Console.ReadLine().Split();
            int A = int.Parse(token[0]);
            int B = int.Parse(token[1]);
            if (A > B) Console.WriteLine(B + " " + A);
            else Console.WriteLine(A + " " + B);
        }
    }
}
