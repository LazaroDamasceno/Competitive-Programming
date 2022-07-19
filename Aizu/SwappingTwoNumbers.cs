using System;
using System.Linq;
using System.Collections.Generic;

namespace InCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token;
            // token = Console.ReadLine().Split(' ');
            while (true)
            {
                token = Console.ReadLine().Split(' ');
                int a = int.Parse(token[0]);
                int b = int.Parse(token[1]);
                if (a == 0 && b == 0)
                {
                    break;
                }
                Console.WriteLine(a < b ? $"{a} {b}" : $"{b} {a}");
            }
        }
    }
}
