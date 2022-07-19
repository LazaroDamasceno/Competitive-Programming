using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] token = Console.ReadLine().Split(' ');
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x > 0 && y > 0 ? 1 :
                x < 0 && y > 0 ? 2 :
                x < 0 && y < 0 ? 3 :
                x > 0 && y < 0 ? 4 : 0);
        }
    }
}
