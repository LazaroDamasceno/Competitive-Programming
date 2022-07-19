using System;
using System.Linq;
using System.Collections.Generic;

namespace InCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(' ');
            int length = int.Parse(token[0]);
            int width = int.Parse(token[1]);
            Console.WriteLine($"{length*width} {2*(length+width)}");
        }
    }
}
