using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int breadth = int.Parse(Console.ReadLine());
            int area = length * breadth;
            int perimeter = 2 * (length + breadth);
            Console.WriteLine(area > perimeter ? $"Area\n{area}" 
                : area < perimeter ? $"Peri\n{perimeter}" : $"Eq\n{area}");
        }
    }
}
