using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input % 4 == 0 ? ++input : --input);
        }
    }
}
