using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine()); 
            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"{area} {circumference}");
        }
    }
}
