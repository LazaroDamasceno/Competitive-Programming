using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token;
            token = Console.ReadLine().Split(' ');
            int one = int.Parse(token[0]);
            int two = int.Parse(token[1]);
            Console.WriteLine(one+two);
        }
    }
}
