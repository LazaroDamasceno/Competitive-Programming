using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] token;
            // token = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());
            int swap = 0;
            swap = (number % 10) * 10;
            number /= 10;
            swap += number;
            Console.WriteLine(swap);
        }
    }
}
