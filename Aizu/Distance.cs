using System;
using System.Linq;
using System.Collections.Generic;

namespace InCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(' ');
            double x1 = double.Parse(token[0]);
            double y1 = double.Parse(token[1]);
            double x2 = double.Parse(token[2]);
            double y2 = double.Parse(token[3]);
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(distance);
        }
    }
}
