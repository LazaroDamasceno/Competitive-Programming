using System;
using System.Linq;
using System.Collections.Generic;

namespace InCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] token;
            // token = Console.ReadLine().Split(' ');
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a > b ? a - b : a + b);
        }
    }
}
