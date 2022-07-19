using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] token = Console.ReadLine().Split();
            Console.WriteLine(ChildrenAndCandies(int.Parse(Console.ReadLine())));
        }

        static int ChildrenAndCandies(int input)
        {
            return input < 1 ? input : input + ChildrenAndCandies(input - 1);
        }
    }
}
